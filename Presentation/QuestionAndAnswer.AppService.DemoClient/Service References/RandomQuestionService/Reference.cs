﻿//------------------------------------------------------------------------------
// <auto-generated>
//	 This code was generated by a tool.
//	 Runtime Version:4.0.30319.18444
//
//	 Changes to this file may cause incorrect behavior and will be lost if
//	 the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JJ.Presentation.QuestionAndAnswer.AppService.DemoClient.RandomQuestionService {
	using System.Runtime.Serialization;
	using System;
	
	
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
	[System.Runtime.Serialization.DataContractAttribute(Name="RandomQuestionViewModel", Namespace="http://schemas.datacontract.org/2004/07/JJ.Presentation.QuestionAndAnswer.ViewModels")]
	[System.SerializableAttribute()]
	public partial class RandomQuestionViewModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
		
		[System.NonSerializedAttribute()]
		private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
		
		[System.Runtime.Serialization.OptionalFieldAttribute()]
		private bool AnswerIsVisibleField;
		
		[System.Runtime.Serialization.OptionalFieldAttribute()]
		private JJ.Presentation.QuestionAndAnswer.AppService.DemoClient.RandomQuestionService.CurrentUserQuestionFlagViewModel CurrentUserQuestionFlagField;
		
		[System.Runtime.Serialization.OptionalFieldAttribute()]
		private JJ.Presentation.QuestionAndAnswer.AppService.DemoClient.RandomQuestionService.QuestionViewModel QuestionField;
		
		[System.Runtime.Serialization.OptionalFieldAttribute()]
		private JJ.Presentation.QuestionAndAnswer.AppService.DemoClient.RandomQuestionService.CategoryViewModel[] SelectedCategoriesField;
		
		[System.Runtime.Serialization.OptionalFieldAttribute()]
		private string UserAnswerField;
		
		[global::System.ComponentModel.BrowsableAttribute(false)]
		public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
			get {
				return this.extensionDataField;
			}
			set {
				this.extensionDataField = value;
			}
		}
		
		[System.Runtime.Serialization.DataMemberAttribute()]
		public bool AnswerIsVisible {
			get {
				return this.AnswerIsVisibleField;
			}
			set {
				if ((this.AnswerIsVisibleField.Equals(value) != true)) {
					this.AnswerIsVisibleField = value;
					this.RaisePropertyChanged("AnswerIsVisible");
				}
			}
		}
		
		[System.Runtime.Serialization.DataMemberAttribute()]
		public JJ.Presentation.QuestionAndAnswer.AppService.DemoClient.RandomQuestionService.CurrentUserQuestionFlagViewModel CurrentUserQuestionFlag {
			get {
				return this.CurrentUserQuestionFlagField;
			}
			set {
				if ((object.ReferenceEquals(this.CurrentUserQuestionFlagField, value) != true)) {
					this.CurrentUserQuestionFlagField = value;
					this.RaisePropertyChanged("CurrentUserQuestionFlag");
				}
			}
		}
		
		[System.Runtime.Serialization.DataMemberAttribute()]
		public JJ.Presentation.QuestionAndAnswer.AppService.DemoClient.RandomQuestionService.QuestionViewModel Question {
			get {
				return this.QuestionField;
			}
			set {
				if ((object.ReferenceEquals(this.QuestionField, value) != true)) {
					this.QuestionField = value;
					this.RaisePropertyChanged("Question");
				}
			}
		}
		
		[System.Runtime.Serialization.DataMemberAttribute()]
		public JJ.Presentation.QuestionAndAnswer.AppService.DemoClient.RandomQuestionService.CategoryViewModel[] SelectedCategories {
			get {
				return this.SelectedCategoriesField;
			}
			set {
				if ((object.ReferenceEquals(this.SelectedCategoriesField, value) != true)) {
					this.SelectedCategoriesField = value;
					this.RaisePropertyChanged("SelectedCategories");
				}
			}
		}
		
		[System.Runtime.Serialization.DataMemberAttribute()]
		public string UserAnswer {
			get {
				return this.UserAnswerField;
			}
			set {
				if ((object.ReferenceEquals(this.UserAnswerField, value) != true)) {
					this.UserAnswerField = value;
					this.RaisePropertyChanged("UserAnswer");
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected void RaisePropertyChanged(string propertyName) {
			System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if ((propertyChanged != null)) {
				propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
	[System.Runtime.Serialization.DataContractAttribute(Name="CurrentUserQuestionFlagViewModel", Namespace="http://schemas.datacontract.org/2004/07/JJ.Presentation.QuestionAndAnswer.ViewModels.Enti" +
		"ties")]
	[System.SerializableAttribute()]
	public partial class CurrentUserQuestionFlagViewModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
		
		[System.NonSerializedAttribute()]
		private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
		
		[System.Runtime.Serialization.OptionalFieldAttribute()]
		private bool CanFlagField;
		
		[System.Runtime.Serialization.OptionalFieldAttribute()]
		private string CommentField;
		
		[System.Runtime.Serialization.OptionalFieldAttribute()]
		private bool IsFlaggedField;
		
		[global::System.ComponentModel.BrowsableAttribute(false)]
		public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
			get {
				return this.extensionDataField;
			}
			set {
				this.extensionDataField = value;
			}
		}
		
		[System.Runtime.Serialization.DataMemberAttribute()]
		public bool CanFlag {
			get {
				return this.CanFlagField;
			}
			set {
				if ((this.CanFlagField.Equals(value) != true)) {
					this.CanFlagField = value;
					this.RaisePropertyChanged("CanFlag");
				}
			}
		}
		
		[System.Runtime.Serialization.DataMemberAttribute()]
		public string Comment {
			get {
				return this.CommentField;
			}
			set {
				if ((object.ReferenceEquals(this.CommentField, value) != true)) {
					this.CommentField = value;
					this.RaisePropertyChanged("Comment");
				}
			}
		}
		
		[System.Runtime.Serialization.DataMemberAttribute()]
		public bool IsFlagged {
			get {
				return this.IsFlaggedField;
			}
			set {
				if ((this.IsFlaggedField.Equals(value) != true)) {
					this.IsFlaggedField = value;
					this.RaisePropertyChanged("IsFlagged");
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected void RaisePropertyChanged(string propertyName) {
			System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if ((propertyChanged != null)) {
				propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
	[System.Runtime.Serialization.DataContractAttribute(Name="QuestionViewModel", Namespace="http://schemas.datacontract.org/2004/07/JJ.Presentation.QuestionAndAnswer.ViewModels.Enti" +
		"ties")]
	[System.SerializableAttribute()]
	public partial class QuestionViewModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
		
		[System.NonSerializedAttribute()]
		private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
		
		[System.Runtime.Serialization.OptionalFieldAttribute()]
		private string AnswerField;
		
		[System.Runtime.Serialization.OptionalFieldAttribute()]
		private JJ.Presentation.QuestionAndAnswer.AppService.DemoClient.RandomQuestionService.QuestionCategoryViewModel[] CategoriesField;
		
		[System.Runtime.Serialization.OptionalFieldAttribute()]
		private JJ.Presentation.QuestionAndAnswer.AppService.DemoClient.RandomQuestionService.QuestionFlagViewModel[] FlagsField;
		
		[System.Runtime.Serialization.OptionalFieldAttribute()]
		private int IDField;
		
		[System.Runtime.Serialization.OptionalFieldAttribute()]
		private bool IsActiveField;
		
		[System.Runtime.Serialization.OptionalFieldAttribute()]
		private bool IsFlaggedField;
		
		[System.Runtime.Serialization.OptionalFieldAttribute()]
		private bool IsManualField;
		
		[System.Runtime.Serialization.OptionalFieldAttribute()]
		private string LastModifiedByField;
		
		[System.Runtime.Serialization.OptionalFieldAttribute()]
		private JJ.Presentation.QuestionAndAnswer.AppService.DemoClient.RandomQuestionService.QuestionLinkViewModel[] LinksField;
		
		[System.Runtime.Serialization.OptionalFieldAttribute()]
		private JJ.Presentation.QuestionAndAnswer.AppService.DemoClient.RandomQuestionService.SourceViewModel SourceField;
		
		[System.Runtime.Serialization.OptionalFieldAttribute()]
		private string TextField;
		
		[System.Runtime.Serialization.OptionalFieldAttribute()]
		private JJ.Presentation.QuestionAndAnswer.AppService.DemoClient.RandomQuestionService.QuestionTypeViewModel TypeField;
		
		[global::System.ComponentModel.BrowsableAttribute(false)]
		public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
			get {
				return this.extensionDataField;
			}
			set {
				this.extensionDataField = value;
			}
		}
		
		[System.Runtime.Serialization.DataMemberAttribute()]
		public string Answer {
			get {
				return this.AnswerField;
			}
			set {
				if ((object.ReferenceEquals(this.AnswerField, value) != true)) {
					this.AnswerField = value;
					this.RaisePropertyChanged("Answer");
				}
			}
		}
		
		[System.Runtime.Serialization.DataMemberAttribute()]
		public JJ.Presentation.QuestionAndAnswer.AppService.DemoClient.RandomQuestionService.QuestionCategoryViewModel[] Categories {
			get {
				return this.CategoriesField;
			}
			set {
				if ((object.ReferenceEquals(this.CategoriesField, value) != true)) {
					this.CategoriesField = value;
					this.RaisePropertyChanged("Categories");
				}
			}
		}
		
		[System.Runtime.Serialization.DataMemberAttribute()]
		public JJ.Presentation.QuestionAndAnswer.AppService.DemoClient.RandomQuestionService.QuestionFlagViewModel[] Flags {
			get {
				return this.FlagsField;
			}
			set {
				if ((object.ReferenceEquals(this.FlagsField, value) != true)) {
					this.FlagsField = value;
					this.RaisePropertyChanged("Flags");
				}
			}
		}
		
		[System.Runtime.Serialization.DataMemberAttribute()]
		public int ID {
			get {
				return this.IDField;
			}
			set {
				if ((this.IDField.Equals(value) != true)) {
					this.IDField = value;
					this.RaisePropertyChanged("ID");
				}
			}
		}
		
		[System.Runtime.Serialization.DataMemberAttribute()]
		public bool IsActive {
			get {
				return this.IsActiveField;
			}
			set {
				if ((this.IsActiveField.Equals(value) != true)) {
					this.IsActiveField = value;
					this.RaisePropertyChanged("IsActive");
				}
			}
		}
		
		[System.Runtime.Serialization.DataMemberAttribute()]
		public bool IsFlagged {
			get {
				return this.IsFlaggedField;
			}
			set {
				if ((this.IsFlaggedField.Equals(value) != true)) {
					this.IsFlaggedField = value;
					this.RaisePropertyChanged("IsFlagged");
				}
			}
		}
		
		[System.Runtime.Serialization.DataMemberAttribute()]
		public bool IsManual {
			get {
				return this.IsManualField;
			}
			set {
				if ((this.IsManualField.Equals(value) != true)) {
					this.IsManualField = value;
					this.RaisePropertyChanged("IsManual");
				}
			}
		}
		
		[System.Runtime.Serialization.DataMemberAttribute()]
		public string LastModifiedBy {
			get {
				return this.LastModifiedByField;
			}
			set {
				if ((object.ReferenceEquals(this.LastModifiedByField, value) != true)) {
					this.LastModifiedByField = value;
					this.RaisePropertyChanged("LastModifiedBy");
				}
			}
		}
		
		[System.Runtime.Serialization.DataMemberAttribute()]
		public JJ.Presentation.QuestionAndAnswer.AppService.DemoClient.RandomQuestionService.QuestionLinkViewModel[] Links {
			get {
				return this.LinksField;
			}
			set {
				if ((object.ReferenceEquals(this.LinksField, value) != true)) {
					this.LinksField = value;
					this.RaisePropertyChanged("Links");
				}
			}
		}
		
		[System.Runtime.Serialization.DataMemberAttribute()]
		public JJ.Presentation.QuestionAndAnswer.AppService.DemoClient.RandomQuestionService.SourceViewModel Source {
			get {
				return this.SourceField;
			}
			set {
				if ((object.ReferenceEquals(this.SourceField, value) != true)) {
					this.SourceField = value;
					this.RaisePropertyChanged("Source");
				}
			}
		}
		
		[System.Runtime.Serialization.DataMemberAttribute()]
		public string Text {
			get {
				return this.TextField;
			}
			set {
				if ((object.ReferenceEquals(this.TextField, value) != true)) {
					this.TextField = value;
					this.RaisePropertyChanged("Text");
				}
			}
		}
		
		[System.Runtime.Serialization.DataMemberAttribute()]
		public JJ.Presentation.QuestionAndAnswer.AppService.DemoClient.RandomQuestionService.QuestionTypeViewModel Type {
			get {
				return this.TypeField;
			}
			set {
				if ((object.ReferenceEquals(this.TypeField, value) != true)) {
					this.TypeField = value;
					this.RaisePropertyChanged("Type");
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected void RaisePropertyChanged(string propertyName) {
			System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if ((propertyChanged != null)) {
				propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
	[System.Runtime.Serialization.DataContractAttribute(Name="CategoryViewModel", Namespace="http://schemas.datacontract.org/2004/07/JJ.Presentation.QuestionAndAnswer.ViewModels.Enti" +
		"ties")]
	[System.SerializableAttribute()]
	public partial class CategoryViewModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
		
		[System.NonSerializedAttribute()]
		private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
		
		[System.Runtime.Serialization.OptionalFieldAttribute()]
		private int IDField;
		
		[System.Runtime.Serialization.OptionalFieldAttribute()]
		private string[] NamePartsField;
		
		[System.Runtime.Serialization.OptionalFieldAttribute()]
		private JJ.Presentation.QuestionAndAnswer.AppService.DemoClient.RandomQuestionService.CategoryViewModel[] SubCategoriesField;
		
		[System.Runtime.Serialization.OptionalFieldAttribute()]
		private bool VisibleField;
		
		[global::System.ComponentModel.BrowsableAttribute(false)]
		public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
			get {
				return this.extensionDataField;
			}
			set {
				this.extensionDataField = value;
			}
		}
		
		[System.Runtime.Serialization.DataMemberAttribute()]
		public int ID {
			get {
				return this.IDField;
			}
			set {
				if ((this.IDField.Equals(value) != true)) {
					this.IDField = value;
					this.RaisePropertyChanged("ID");
				}
			}
		}
		
		[System.Runtime.Serialization.DataMemberAttribute()]
		public string[] NameParts {
			get {
				return this.NamePartsField;
			}
			set {
				if ((object.ReferenceEquals(this.NamePartsField, value) != true)) {
					this.NamePartsField = value;
					this.RaisePropertyChanged("NameParts");
				}
			}
		}
		
		[System.Runtime.Serialization.DataMemberAttribute()]
		public JJ.Presentation.QuestionAndAnswer.AppService.DemoClient.RandomQuestionService.CategoryViewModel[] SubCategories {
			get {
				return this.SubCategoriesField;
			}
			set {
				if ((object.ReferenceEquals(this.SubCategoriesField, value) != true)) {
					this.SubCategoriesField = value;
					this.RaisePropertyChanged("SubCategories");
				}
			}
		}
		
		[System.Runtime.Serialization.DataMemberAttribute()]
		public bool Visible {
			get {
				return this.VisibleField;
			}
			set {
				if ((this.VisibleField.Equals(value) != true)) {
					this.VisibleField = value;
					this.RaisePropertyChanged("Visible");
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected void RaisePropertyChanged(string propertyName) {
			System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if ((propertyChanged != null)) {
				propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
	[System.Runtime.Serialization.DataContractAttribute(Name="SourceViewModel", Namespace="http://schemas.datacontract.org/2004/07/JJ.Presentation.QuestionAndAnswer.ViewModels.Enti" +
		"ties")]
	[System.SerializableAttribute()]
	public partial class SourceViewModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
		
		[System.NonSerializedAttribute()]
		private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
		
		[System.Runtime.Serialization.OptionalFieldAttribute()]
		private string DescriptionField;
		
		[System.Runtime.Serialization.OptionalFieldAttribute()]
		private int IDField;
		
		[System.Runtime.Serialization.OptionalFieldAttribute()]
		private string UrlField;
		
		[global::System.ComponentModel.BrowsableAttribute(false)]
		public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
			get {
				return this.extensionDataField;
			}
			set {
				this.extensionDataField = value;
			}
		}
		
		[System.Runtime.Serialization.DataMemberAttribute()]
		public string Description {
			get {
				return this.DescriptionField;
			}
			set {
				if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
					this.DescriptionField = value;
					this.RaisePropertyChanged("Description");
				}
			}
		}
		
		[System.Runtime.Serialization.DataMemberAttribute()]
		public int ID {
			get {
				return this.IDField;
			}
			set {
				if ((this.IDField.Equals(value) != true)) {
					this.IDField = value;
					this.RaisePropertyChanged("ID");
				}
			}
		}
		
		[System.Runtime.Serialization.DataMemberAttribute()]
		public string Url {
			get {
				return this.UrlField;
			}
			set {
				if ((object.ReferenceEquals(this.UrlField, value) != true)) {
					this.UrlField = value;
					this.RaisePropertyChanged("Url");
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected void RaisePropertyChanged(string propertyName) {
			System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if ((propertyChanged != null)) {
				propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
	[System.Runtime.Serialization.DataContractAttribute(Name="QuestionTypeViewModel", Namespace="http://schemas.datacontract.org/2004/07/JJ.Presentation.QuestionAndAnswer.ViewModels.Enti" +
		"ties")]
	[System.SerializableAttribute()]
	public partial class QuestionTypeViewModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
		
		[System.NonSerializedAttribute()]
		private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
		
		[System.Runtime.Serialization.OptionalFieldAttribute()]
		private int IDField;
		
		[System.Runtime.Serialization.OptionalFieldAttribute()]
		private string NameField;
		
		[global::System.ComponentModel.BrowsableAttribute(false)]
		public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
			get {
				return this.extensionDataField;
			}
			set {
				this.extensionDataField = value;
			}
		}
		
		[System.Runtime.Serialization.DataMemberAttribute()]
		public int ID {
			get {
				return this.IDField;
			}
			set {
				if ((this.IDField.Equals(value) != true)) {
					this.IDField = value;
					this.RaisePropertyChanged("ID");
				}
			}
		}
		
		[System.Runtime.Serialization.DataMemberAttribute()]
		public string Name {
			get {
				return this.NameField;
			}
			set {
				if ((object.ReferenceEquals(this.NameField, value) != true)) {
					this.NameField = value;
					this.RaisePropertyChanged("Name");
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected void RaisePropertyChanged(string propertyName) {
			System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if ((propertyChanged != null)) {
				propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
	[System.Runtime.Serialization.DataContractAttribute(Name="QuestionCategoryViewModel", Namespace="http://schemas.datacontract.org/2004/07/JJ.Presentation.QuestionAndAnswer.ViewModels.Enti" +
		"ties")]
	[System.SerializableAttribute()]
	public partial class QuestionCategoryViewModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
		
		[System.NonSerializedAttribute()]
		private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
		
		[System.Runtime.Serialization.OptionalFieldAttribute()]
		private JJ.Presentation.QuestionAndAnswer.AppService.DemoClient.RandomQuestionService.CategoryViewModel CategoryField;
		
		[System.Runtime.Serialization.OptionalFieldAttribute()]
		private int QuestionCategoryIDField;
		
		[System.Runtime.Serialization.OptionalFieldAttribute()]
		private System.Guid TemporaryIDField;
		
		[global::System.ComponentModel.BrowsableAttribute(false)]
		public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
			get {
				return this.extensionDataField;
			}
			set {
				this.extensionDataField = value;
			}
		}
		
		[System.Runtime.Serialization.DataMemberAttribute()]
		public JJ.Presentation.QuestionAndAnswer.AppService.DemoClient.RandomQuestionService.CategoryViewModel Category {
			get {
				return this.CategoryField;
			}
			set {
				if ((object.ReferenceEquals(this.CategoryField, value) != true)) {
					this.CategoryField = value;
					this.RaisePropertyChanged("Category");
				}
			}
		}
		
		[System.Runtime.Serialization.DataMemberAttribute()]
		public int QuestionCategoryID {
			get {
				return this.QuestionCategoryIDField;
			}
			set {
				if ((this.QuestionCategoryIDField.Equals(value) != true)) {
					this.QuestionCategoryIDField = value;
					this.RaisePropertyChanged("QuestionCategoryID");
				}
			}
		}
		
		[System.Runtime.Serialization.DataMemberAttribute()]
		public System.Guid TemporaryID {
			get {
				return this.TemporaryIDField;
			}
			set {
				if ((this.TemporaryIDField.Equals(value) != true)) {
					this.TemporaryIDField = value;
					this.RaisePropertyChanged("TemporaryID");
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected void RaisePropertyChanged(string propertyName) {
			System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if ((propertyChanged != null)) {
				propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
	[System.Runtime.Serialization.DataContractAttribute(Name="QuestionFlagViewModel", Namespace="http://schemas.datacontract.org/2004/07/JJ.Presentation.QuestionAndAnswer.ViewModels.Enti" +
		"ties")]
	[System.SerializableAttribute()]
	public partial class QuestionFlagViewModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
		
		[System.NonSerializedAttribute()]
		private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
		
		[System.Runtime.Serialization.OptionalFieldAttribute()]
		private string CommentField;
		
		[System.Runtime.Serialization.OptionalFieldAttribute()]
		private System.DateTime DateAndTimeField;
		
		[System.Runtime.Serialization.OptionalFieldAttribute()]
		private string FlaggedByField;
		
		[System.Runtime.Serialization.OptionalFieldAttribute()]
		private int IDField;
		
		[System.Runtime.Serialization.OptionalFieldAttribute()]
		private string LastModifiedByField;
		
		[System.Runtime.Serialization.OptionalFieldAttribute()]
		private JJ.Presentation.QuestionAndAnswer.AppService.DemoClient.RandomQuestionService.FlagStatusViewModel StatusField;
		
		[global::System.ComponentModel.BrowsableAttribute(false)]
		public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
			get {
				return this.extensionDataField;
			}
			set {
				this.extensionDataField = value;
			}
		}
		
		[System.Runtime.Serialization.DataMemberAttribute()]
		public string Comment {
			get {
				return this.CommentField;
			}
			set {
				if ((object.ReferenceEquals(this.CommentField, value) != true)) {
					this.CommentField = value;
					this.RaisePropertyChanged("Comment");
				}
			}
		}
		
		[System.Runtime.Serialization.DataMemberAttribute()]
		public System.DateTime DateAndTime {
			get {
				return this.DateAndTimeField;
			}
			set {
				if ((this.DateAndTimeField.Equals(value) != true)) {
					this.DateAndTimeField = value;
					this.RaisePropertyChanged("DateAndTime");
				}
			}
		}
		
		[System.Runtime.Serialization.DataMemberAttribute()]
		public string FlaggedBy {
			get {
				return this.FlaggedByField;
			}
			set {
				if ((object.ReferenceEquals(this.FlaggedByField, value) != true)) {
					this.FlaggedByField = value;
					this.RaisePropertyChanged("FlaggedBy");
				}
			}
		}
		
		[System.Runtime.Serialization.DataMemberAttribute()]
		public int ID {
			get {
				return this.IDField;
			}
			set {
				if ((this.IDField.Equals(value) != true)) {
					this.IDField = value;
					this.RaisePropertyChanged("ID");
				}
			}
		}
		
		[System.Runtime.Serialization.DataMemberAttribute()]
		public string LastModifiedBy {
			get {
				return this.LastModifiedByField;
			}
			set {
				if ((object.ReferenceEquals(this.LastModifiedByField, value) != true)) {
					this.LastModifiedByField = value;
					this.RaisePropertyChanged("LastModifiedBy");
				}
			}
		}
		
		[System.Runtime.Serialization.DataMemberAttribute()]
		public JJ.Presentation.QuestionAndAnswer.AppService.DemoClient.RandomQuestionService.FlagStatusViewModel Status {
			get {
				return this.StatusField;
			}
			set {
				if ((object.ReferenceEquals(this.StatusField, value) != true)) {
					this.StatusField = value;
					this.RaisePropertyChanged("Status");
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected void RaisePropertyChanged(string propertyName) {
			System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if ((propertyChanged != null)) {
				propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
	[System.Runtime.Serialization.DataContractAttribute(Name="QuestionLinkViewModel", Namespace="http://schemas.datacontract.org/2004/07/JJ.Presentation.QuestionAndAnswer.ViewModels.Enti" +
		"ties")]
	[System.SerializableAttribute()]
	public partial class QuestionLinkViewModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
		
		[System.NonSerializedAttribute()]
		private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
		
		[System.Runtime.Serialization.OptionalFieldAttribute()]
		private string DescriptionField;
		
		[System.Runtime.Serialization.OptionalFieldAttribute()]
		private int IDField;
		
		[System.Runtime.Serialization.OptionalFieldAttribute()]
		private System.Guid TemporaryIDField;
		
		[System.Runtime.Serialization.OptionalFieldAttribute()]
		private string UrlField;
		
		[global::System.ComponentModel.BrowsableAttribute(false)]
		public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
			get {
				return this.extensionDataField;
			}
			set {
				this.extensionDataField = value;
			}
		}
		
		[System.Runtime.Serialization.DataMemberAttribute()]
		public string Description {
			get {
				return this.DescriptionField;
			}
			set {
				if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
					this.DescriptionField = value;
					this.RaisePropertyChanged("Description");
				}
			}
		}
		
		[System.Runtime.Serialization.DataMemberAttribute()]
		public int ID {
			get {
				return this.IDField;
			}
			set {
				if ((this.IDField.Equals(value) != true)) {
					this.IDField = value;
					this.RaisePropertyChanged("ID");
				}
			}
		}
		
		[System.Runtime.Serialization.DataMemberAttribute()]
		public System.Guid TemporaryID {
			get {
				return this.TemporaryIDField;
			}
			set {
				if ((this.TemporaryIDField.Equals(value) != true)) {
					this.TemporaryIDField = value;
					this.RaisePropertyChanged("TemporaryID");
				}
			}
		}
		
		[System.Runtime.Serialization.DataMemberAttribute()]
		public string Url {
			get {
				return this.UrlField;
			}
			set {
				if ((object.ReferenceEquals(this.UrlField, value) != true)) {
					this.UrlField = value;
					this.RaisePropertyChanged("Url");
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected void RaisePropertyChanged(string propertyName) {
			System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if ((propertyChanged != null)) {
				propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
	[System.Runtime.Serialization.DataContractAttribute(Name="FlagStatusViewModel", Namespace="http://schemas.datacontract.org/2004/07/JJ.Presentation.QuestionAndAnswer.ViewModels.Enti" +
		"ties")]
	[System.SerializableAttribute()]
	public partial class FlagStatusViewModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
		
		[System.NonSerializedAttribute()]
		private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
		
		[System.Runtime.Serialization.OptionalFieldAttribute()]
		private string DescriptionField;
		
		[System.Runtime.Serialization.OptionalFieldAttribute()]
		private int IDField;
		
		[global::System.ComponentModel.BrowsableAttribute(false)]
		public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
			get {
				return this.extensionDataField;
			}
			set {
				this.extensionDataField = value;
			}
		}
		
		[System.Runtime.Serialization.DataMemberAttribute()]
		public string Description {
			get {
				return this.DescriptionField;
			}
			set {
				if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
					this.DescriptionField = value;
					this.RaisePropertyChanged("Description");
				}
			}
		}
		
		[System.Runtime.Serialization.DataMemberAttribute()]
		public int ID {
			get {
				return this.IDField;
			}
			set {
				if ((this.IDField.Equals(value) != true)) {
					this.IDField = value;
					this.RaisePropertyChanged("ID");
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected void RaisePropertyChanged(string propertyName) {
			System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if ((propertyChanged != null)) {
				propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ServiceModel.ServiceContractAttribute(ConfigurationName="RandomQuestionService.IRandomQuestionService")]
	public interface IRandomQuestionService {
		
		[System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRandomQuestionService/ShowQuestion", ReplyAction="http://tempuri.org/IRandomQuestionService/ShowQuestionResponse")]
		JJ.Presentation.QuestionAndAnswer.AppService.DemoClient.RandomQuestionService.RandomQuestionViewModel ShowQuestion();
		
		[System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRandomQuestionService/ShowQuestion", ReplyAction="http://tempuri.org/IRandomQuestionService/ShowQuestionResponse")]
		System.Threading.Tasks.Task<JJ.Presentation.QuestionAndAnswer.AppService.DemoClient.RandomQuestionService.RandomQuestionViewModel> ShowQuestionAsync();
		
		[System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRandomQuestionService/ShowAnswer", ReplyAction="http://tempuri.org/IRandomQuestionService/ShowAnswerResponse")]
		JJ.Presentation.QuestionAndAnswer.AppService.DemoClient.RandomQuestionService.RandomQuestionViewModel ShowAnswer(JJ.Presentation.QuestionAndAnswer.AppService.DemoClient.RandomQuestionService.RandomQuestionViewModel viewModel);
		
		[System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRandomQuestionService/ShowAnswer", ReplyAction="http://tempuri.org/IRandomQuestionService/ShowAnswerResponse")]
		System.Threading.Tasks.Task<JJ.Presentation.QuestionAndAnswer.AppService.DemoClient.RandomQuestionService.RandomQuestionViewModel> ShowAnswerAsync(JJ.Presentation.QuestionAndAnswer.AppService.DemoClient.RandomQuestionService.RandomQuestionViewModel viewModel);
		
		[System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRandomQuestionService/HideAnswer", ReplyAction="http://tempuri.org/IRandomQuestionService/HideAnswerResponse")]
		JJ.Presentation.QuestionAndAnswer.AppService.DemoClient.RandomQuestionService.RandomQuestionViewModel HideAnswer(JJ.Presentation.QuestionAndAnswer.AppService.DemoClient.RandomQuestionService.RandomQuestionViewModel viewModel);
		
		[System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRandomQuestionService/HideAnswer", ReplyAction="http://tempuri.org/IRandomQuestionService/HideAnswerResponse")]
		System.Threading.Tasks.Task<JJ.Presentation.QuestionAndAnswer.AppService.DemoClient.RandomQuestionService.RandomQuestionViewModel> HideAnswerAsync(JJ.Presentation.QuestionAndAnswer.AppService.DemoClient.RandomQuestionService.RandomQuestionViewModel viewModel);
	}
	
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	public interface IRandomQuestionServiceChannel : JJ.Presentation.QuestionAndAnswer.AppService.DemoClient.RandomQuestionService.IRandomQuestionService, System.ServiceModel.IClientChannel {
	}
	
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	public partial class RandomQuestionServiceClient : System.ServiceModel.ClientBase<JJ.Presentation.QuestionAndAnswer.AppService.DemoClient.RandomQuestionService.IRandomQuestionService>, JJ.Presentation.QuestionAndAnswer.AppService.DemoClient.RandomQuestionService.IRandomQuestionService {
		
		public RandomQuestionServiceClient() {
		}
		
		public RandomQuestionServiceClient(string endpointConfigurationName) : 
				base(endpointConfigurationName) {
		}
		
		public RandomQuestionServiceClient(string endpointConfigurationName, string remoteAddress) : 
				base(endpointConfigurationName, remoteAddress) {
		}
		
		public RandomQuestionServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
				base(endpointConfigurationName, remoteAddress) {
		}
		
		public RandomQuestionServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
				base(binding, remoteAddress) {
		}
		
		public JJ.Presentation.QuestionAndAnswer.AppService.DemoClient.RandomQuestionService.RandomQuestionViewModel ShowQuestion() {
			return base.Channel.ShowQuestion();
		}
		
		public System.Threading.Tasks.Task<JJ.Presentation.QuestionAndAnswer.AppService.DemoClient.RandomQuestionService.RandomQuestionViewModel> ShowQuestionAsync() {
			return base.Channel.ShowQuestionAsync();
		}
		
		public JJ.Presentation.QuestionAndAnswer.AppService.DemoClient.RandomQuestionService.RandomQuestionViewModel ShowAnswer(JJ.Presentation.QuestionAndAnswer.AppService.DemoClient.RandomQuestionService.RandomQuestionViewModel viewModel) {
			return base.Channel.ShowAnswer(viewModel);
		}
		
		public System.Threading.Tasks.Task<JJ.Presentation.QuestionAndAnswer.AppService.DemoClient.RandomQuestionService.RandomQuestionViewModel> ShowAnswerAsync(JJ.Presentation.QuestionAndAnswer.AppService.DemoClient.RandomQuestionService.RandomQuestionViewModel viewModel) {
			return base.Channel.ShowAnswerAsync(viewModel);
		}
		
		public JJ.Presentation.QuestionAndAnswer.AppService.DemoClient.RandomQuestionService.RandomQuestionViewModel HideAnswer(JJ.Presentation.QuestionAndAnswer.AppService.DemoClient.RandomQuestionService.RandomQuestionViewModel viewModel) {
			return base.Channel.HideAnswer(viewModel);
		}
		
		public System.Threading.Tasks.Task<JJ.Presentation.QuestionAndAnswer.AppService.DemoClient.RandomQuestionService.RandomQuestionViewModel> HideAnswerAsync(JJ.Presentation.QuestionAndAnswer.AppService.DemoClient.RandomQuestionService.RandomQuestionViewModel viewModel) {
			return base.Channel.HideAnswerAsync(viewModel);
		}
	}
}
