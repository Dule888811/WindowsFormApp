<p>
 General


All code must be written using C# and Windows Forms (.NET 4.5 or newer and Visual Studio 2017)

Test results may contain multiple projects but all projects must be a part of a single Visual Studio solution. The solution must be fully buildable without any errors or warnings

All code identifiers (forms, components, classes, methods, properties, fields…) must be named using
meaningful English names describing their function 3rd party components are not all

Task


We need a GUI application (windows Forms) that will provide functionality to search entered string in all text files in selected folder (and all its subfolders).

When started, the application must provide mechanism to select desired folder and enter search string (you can use FolderBrowserDialog for folder selection).
You can limit the search to .txt files or allow the user to select custom extension (.txt should be default)

Once user initiates the search, application will need to traverse selected folder (and all of it’s
subfolders) for selected file types and search each file content for entered search string

Once the search is over, the application needs to show all files which contain search string (show a list of files), along with number of repetitions of said string

When the file (in list) is double clicked, the application needs to open that file using ShellExecute (use Process.Start)

Implement mechanism to view selected file directly in application



Results


After receiving this document time allowed for sending back test results is 2 days. Time limit exceeding is not allowed

Results should be submitted as a fully buildable single solution and source code files only, excluding all binaries and executables

Please send back a single archive file containing all the results as an email attachment, send directly to
jobs@apexsql.com

We can’t accept test results sent in any other way (i.e. file sharing website URL, multiple email attachments, multiple emails, etc.)



 Notes
 
 
Additional test clarification or consultations are not available and all such emails will be ignored until the test is completed. When in doubt resolve all questions and concerns the best way you see fit

Time spent during the test is unpaid. ApexSQL will not use the developed code or software in any way other than to evaluate candidate skills

Focus should be on solution completeness, code consistency, code quality, and documentation

We don’t give extra credit for a quick turnaround so use as much time available as needed to do your best

We reserve the right to reject all results that don’t comply with the test requirements

After the test is over we guarantee that we will provide feedback about our final decision, but we will not provide details about the test results or test scores


In the texbox below the button enter the part of the string you are searching for, click on the buuton and select the place you are looking for on the hard disk.
The results are displayed in a listbox, below each result is the number of string repetitions in that document. Documents are limited to text and double-clicking 
 on the result document opens the document. Texbox above buuton serves me as an auxiliary part of the application, does not mean useless.

</p>
