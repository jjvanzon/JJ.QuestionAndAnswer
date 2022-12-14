Question & Answer Release 1.2
=============================

*2021-05-15*

<h2>Contents</h2>

- [Introduction](#introduction)
- [Changes](#changes)
- [Warning: Weak Password Security](#warning-weak-password-security)
- [Prerequisites](#prerequisites)
- [Database](#database)
- [Web Site Files](#web-site-files)
- [Import Tool](#import-tool)
    - [General Installation Steps](#general-installation-steps)
    - [Description of Import Tool](#description-of-import-tool)
    - [Imperfections](#imperfections)
- [IO Files](#io-files)

Introduction
------------

Question & Answer is an app that might train knowledge about certain topics, by randomly asking questions about raw facts about the topic.

Installation instructions might be found in the README as wel a description of some imperfections.


Changes
-------

- Changes to Question & Answer Import:
- Tried to removed excessive "-->" from (Prod) config.
- Tried to show message box upon exception.
- Tried giving it a more esthetic window title.


Warning: Weak Password Security
-------------------------------

Passwords in database are not encrypted (stored as plain-text). So better not use passwords that would also protect your valuables. Here are the user names and passwords currently available:

    admin	enteentest0!
    devjj79	enteentest0!


Prerequisites
-------------

- *Microsoft SQL Server* may be required, which may be downloaded elsewhere.
- IIS (Internet Information Services) might be needed, which may be installed by activating it as a *Windows component* on some operating systems.


Database
--------

- The database backup may be in the file "QuestionAndAnswerDB.1.2.zip"
- The file might be unzipped and restored in SQL Server with name PROD_QuestionAndAnswerDB.
- The database user name "prod" may be expected with password "prod".
- If needed, different database name / user name / password might be configured.
- The configs in the web site files and/or import tool might need to be changed for that.


Web Site Files
--------------

- "JJ.Presentation.QuestionAndAnswer.Mvc.1.2.zip" may contain the web site files.
- It is suggested to create an IIS web site that uses (a copy of) that folder.


Import Tool
-----------

### General Installation Steps

- "JJ.Presentation.QuestionAndAnswer.Import.WinForms.1.2.zip" might contain an import tool.
- It has no installer.
- It might be unzipped and put somewhere on a computer and then perhaps a shortcut made to it.

### Description of Import Tool

- The import tool may once have filled the database with relatively static content.
- Questions with answers and other content.
- This import tool might not need to run again.
- Using its config, imports may be selected to run or not.
- The config may also allow you to select the file path of a possible file to import. ("JJ.Presentation.QuestionAndAnswer.Import.WinForms.exe.config")

### Imperfections

- Running it again, may not be entirely without consequence.
- Unintended impact of rerunning it, might be subtle.
- *Manual edits* to questions might be overwritten by an import.
- *Content flaggings* might be removed for re-imported questions.


IO Files
--------

- Might be found in "QuestionAndAnswer.IO.Files.1.2.zip".
- These files that may originally have been imported into the database using the Import Tool.
- It is suggested to copy them to a sub-folder "IO Files" in the installation folder of the Import Tool.
- If reimporting is desired, configuration of the import tool may be used to select which imports might run. ("JJ.Presentation.QuestionAndAnswer.Import.WinForms.exe.config")
- And let the config entries point to the desired file location of an IO file.