﻿using JJ.Business.QuestionAndAnswer.Import;
using JJ.Business.QuestionAndAnswer.Import.W3CSpecCss3.Models;
using JJ.Framework.Common;
using JJ.Framework.IO;
using JJ.Framework.Xml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Xml;

namespace JJ.Business.QuestionAndAnswer.Import.W3CSpecCss3.Selectors
{
    public class W3CSpecCss3_PropertyIndex_HtmlSelector : ISelector<PropertyAspectsImportModel>
    {
        public IEnumerable<PropertyAspectsImportModel> GetSelection(Stream stream)
        {
            if (stream == null) throw new ArgumentNullException("stream");

            using (var streamReader = new StreamReader(stream))
            {
                string html = streamReader.ReadToEnd();
                string xml = HtmlToXmlConverter.Convert(html);

                // Make sure <br /> comes back as whitespace of InnerText.
                xml = xml.Replace("<br />", " ");

                // Trick to keep 'plural' properties separated.
                xml = xml.Replace("<code>", "<code> ");

                XmlDocument doc = new XmlDocument();
                doc.LoadXml(xml);

                foreach (XmlNode node in GetRecords(doc))
                {
                    PropertyAspectsImportModel importModel = CreateImportModel(node);
                    yield return importModel;
                }
            }
        }

        private IEnumerable<XmlNode> GetRecords(XmlDocument doc)
        {
            string xpath = "//table[@class='proptable']/tbody/tr";
            XmlNodeList nodes = doc.SelectNodes(xpath);
            return nodes.OfType<XmlNode>();
        }

        private PropertyAspectsImportModel CreateImportModel(XmlNode node)
        {
            var model = new PropertyAspectsImportModel
            {
                PropertyName = GetName(node),
                PossibleValues = GetPossibleValues(node),
                InitialValue = GetInitialValue(node),
                AppliesTo = GetAppliesTo(node),
                IsInherited = GetIsInherited(node),
                Percentages = GetPercentages(node),
                Media = GetMedia(node),
                
                NameLinks = GetNameLinks(node).ToList(),
                PossibleValuesLinks = GetPossibleValuesLinks(node).ToList(),
                InitialValueLinks = GetInitialValueLinks(node).ToList(),
                AppliesToLinks = GetAppliesToLinks(node).ToList(),
                IsInheritedLinks = GetIsInheritedLinks(node).ToList(),
                PercentagesLinks = GetPercentagesLinks(node).ToList(),
                MediaLinks = GetMediaLinks(node).ToList()
            };

            return model;
        }

        private string GetName(XmlNode node)
        {
            string xpath = "th";
            string value = SelectText(node, xpath);
            return value;
        }

        private string GetPossibleValues(XmlNode node)
        {
            string xpath = "td[1]";
            string value = SelectText(node, xpath);
            return value;
        }

        private string GetInitialValue(XmlNode node)
        {
            string xpath = "td[2]";
            string value = SelectText(node, xpath);
            return value;
        }

        private string GetAppliesTo(XmlNode node)
        {
            string xpath = "td[3]";
            string value = SelectText(node, xpath);
            return value;
        }

        private string GetIsInherited(XmlNode node)
        {
            string xpath = "td[4]";
            string value = SelectText(node, xpath);
            return value;
        }

        private string GetPercentages(XmlNode node)
        {
            string xpath = "td[5]";
            string value = SelectText(node, xpath);
            return value;
        }

        private string GetMedia(XmlNode node)
        {
            string xpath = "td[6]";
            string value = SelectText(node, xpath);
            return value;
        }

        private IEnumerable<LinkModel> GetNameLinks(XmlNode node)
        {
            return GetLinks(node, "th/a");
        }

        private IEnumerable<LinkModel> GetPossibleValuesLinks(XmlNode node)
        {
            return GetLinks(node, "td[1]/a");
        }

        private IEnumerable<LinkModel> GetInitialValueLinks(XmlNode node)
        {
            return GetLinks(node, "td[2]/a");
        }

        private IEnumerable<LinkModel> GetAppliesToLinks(XmlNode node)
        {
            return GetLinks(node, "td[3]/a");
        }

        private IEnumerable<LinkModel> GetIsInheritedLinks(XmlNode node)
        {
            return GetLinks(node, "td[4]/a");
        }

        private IEnumerable<LinkModel> GetPercentagesLinks(XmlNode node)
        {
            return GetLinks(node, "td[5]/a");
        }

        private IEnumerable<LinkModel> GetMediaLinks(XmlNode node)
        {
            return GetLinks(node, "td[6]/a");
        }

        private IEnumerable<LinkModel> GetLinks(XmlNode node, string xpath)
        {
            foreach (XmlNode node2 in node.SelectNodes(xpath))
            {
                LinkModel model = CreateLinkModel(node2);
                yield return model;
            }
        }

        private LinkModel CreateLinkModel(XmlNode node)
        {
            var model = new LinkModel
            {
                Description = GetLinkDescription(node),
                Url = GetLinkUrl(node)
            };

            return model;
        }

        private string GetLinkDescription(XmlNode node)
        {
            string text = ImportHelper.FormatHtmlText(node.InnerText);
            return text;
        }

        private string GetLinkUrl(XmlNode node)
        {
            string xpath = "@href";
            XmlNode node2 = XmlHelper.SelectNode(node, xpath);
            return node2.Value;
        }

        // Helpers

        private string SelectText(XmlNode node, string xpath)
        {
            XmlNode node2 = XmlHelper.SelectNode(node, xpath);
            string text = ImportHelper.FormatHtmlText(node2.InnerText);
            return text;
        }
    }
}