using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProcessEmailBody
{
    class Program
    {
        static void Main(string[] args)
        {

            string a1 = "DataErase";
            string s2 = "DataAccess"; 

            if (a1.Equals("DataErase"))
            {
                Console.WriteLine(a1);
            }
            else
            {
                Console.WriteLine("Not Data earase"); 
            }

            string GDRPEmailBoxIn = "< html >\r\n < head >\r\n < meta http - equiv =\"Content-Type\" content=\"text/html; charset=utf-8\">\r\n<meta content=\"text/html; charset=us-ascii\">\r\n<meta name=\"Generator\" content=\"Microsoft Word 15 (filtered medium)\">\r\n<style>\r\n<!--\r\n@font-face\r\n\t{font-family:\"Cambria Math\"}\r\n@font-face\r\n\t{font-family:Calibri}\r\np.MsoNormal, li.MsoNormal, div.MsoNormal\r\n\t{margin:0in;\r\n\tmargin-bottom:.0001pt;\r\n\tfont-size:11.0pt;\r\n\tfont-family:\"Calibri\",sans-serif}\r\na:link, span.MsoHyperlink\r\n\t{color:#0563C1;\r\n\ttext-decoration:underline}\r\na:visited, span.MsoHyperlinkFollowed\r\n\t{color:#954F72;\r\n\ttext-decoration:underline}\r\np.MsoPlainText, li.MsoPlainText, div.MsoPlainText\r\n\t{margin:0in;\r\n\tmargin-bottom:.0001pt;\r\n\tfont-size:11.0pt;\r\n\tfont-family:\"Calibri\",sans-serif}\r\np.msonormal0, li.msonormal0, div.msonormal0\r\n\t{margin-right:0in;\r\n\tmargin-left:0in;\r\n\tfont-size:12.0pt;\r\n\tfont-family:\"Times New Roman\",serif}\r\nspan.PlainTextChar\r\n\t{font-family:\"Calibri\",sans-serif}\r\nspan.EmailStyle20\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:windowtext}\r\nspan.EmailStyle21\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle22\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle23\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle24\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle25\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle26\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle27\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle28\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle29\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle30\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle31\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle32\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle33\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle34\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle35\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle36\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle37\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle38\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle39\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle40\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle41\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle42\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle43\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle44\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle45\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle46\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle47\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\n.MsoChpDefault\r\n\t{font-size:10.0pt}\r\n@page WordSection1\r\n\t{margin:1.0in 1.0in 1.0in 1.0in}\r\ndiv.WordSection1\r\n\t{}\r\n-->\r\n</style>\r\n</head>\r\n<body lang=\"EN-US\" link=\"#0563C1\" vlink=\"#954F72\">\r\n<div class=\"WordSection1\">\r\n<p class=\"MsoPlainText\">###############################################</p>\r\n<p class=\"MsoPlainText\">Date:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 2018/02/19 00:00:00</p>\r\n<p class=\"MsoPlainText\">File Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 1CP_GCR00027937_GDPRBroadcastExtract_GBR_ALL_DataAccess_20180219220004.txt</p>\r\n<p class=\"MsoPlainText\">Status:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; SUCCESS</p>\r\n<p class=\"MsoPlainText\">SFTP Path:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; /mnt/data/data02/outbound/GDPRBroadcast/GBR/ALL</p>\r\n<p class=\"MsoPlainText\">Case ID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;GCR00027937</p>\r\n<p class=\"MsoPlainText\">Gdpr Request Type:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; DataAccess</p>\r\n<p class=\"MsoPlainText\">###############################################</p>\r\n<p class=\"MsoNormal\">&nbsp;</p>\r\n</div>\r\n<br>\r\n<hr>\r\n<font face=\"Arial\" color=\"Gray\" size=\"1\"><br>\r\nhttp://www.mindtree.com/email/disclaimer.html<br>\r\n</font>\r\n</body>\r\n</html>\r\n";


            string liveEmailBody = "<html>\r\n<head>\r\n<meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\">\r\n<meta content=\"text/html; charset=iso-8859-1\">\r\n<style type=\"text/css\" style=\"display:none\">\r\n<!--\r\np\r\n\t{margin-top:0;\r\n\tmargin-bottom:0}\r\n-->\r\n</style>\r\n</head>\r\n<body dir=\"ltr\">\r\n<div style=\"font-family:Calibri,Arial,Helvetica,sans-serif; font-size:12pt; color:rgb(0,0,0)\">\r\n<p style=\"margin:0in 0in 0.0001pt; font-size:11pt; font-family:Calibri,sans-serif\">\r\n############################################### </p>\r\n<p style=\"margin:0in 0in 0.0001pt; font-size:11pt; font-family:Calibri,sans-serif\">\r\nDate:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 2018/10/25 00:00:00</p>\r\n<p style=\"margin:0in 0in 0.0001pt; font-size:11pt; font-family:Calibri,sans-serif\">\r\nFile Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 1CP_GCR08011756_GDPRBroadcastExtract_GBR_Mindtree_DataPortability_20190117220004.txt</p>\r\n<p style=\"margin:0in 0in 0.0001pt; font-size:11pt; font-family:Calibri,sans-serif\">\r\nStatus:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; SUCCESS</p>\r\n<p style=\"margin:0in 0in 0.0001pt; font-size:11pt; font-family:Calibri,sans-serif\">\r\nSFTP Path:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; /mnt/data/data02/outbound/GDPRBroadcast/GBR/Mindtree</p>\r\n<p style=\"margin:0in 0in 0.0001pt; font-size:11pt; font-family:Calibri,sans-serif\">\r\nCase ID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; GCR07315178</p>\r\n<p style=\"margin:0in 0in 0.0001pt; font-size:11pt; font-family:Calibri,sans-serif\">\r\nGdpr Request Type:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; DataErase</p>\r\n<p style=\"margin:0in 0in 0.0001pt; font-size:11pt; font-family:Calibri,sans-serif\">\r\n###############################################</p>\r\n<br>\r\n</div>\r\n</body>\r\n</html>\r\n";

            


            string emailBodyContent = "< html >\r\n < head >\r\n < meta http - equiv =\"Content-Type\" content=\"text/html; charset=utf-8\">\r\n<meta content=\"text/html; charset=us-ascii\">\r\n<meta name=\"Generator\" content=\"Microsoft Word 15 (filtered medium)\">\r\n<style>\r\n<!--\r\n@font-face\r\n\t{font-family:\"Cambria Math\"}\r\n@font-face\r\n\t{font-family:Calibri}\r\np.MsoNormal, li.MsoNormal, div.MsoNormal\r\n\t{margin:0in;\r\n\tmargin-bottom:.0001pt;\r\n\tfont-size:11.0pt;\r\n\tfont-family:\"Calibri\",sans-serif}\r\na:link, span.MsoHyperlink\r\n\t{color:#0563C1;\r\n\ttext-decoration:underline}\r\na:visited, span.MsoHyperlinkFollowed\r\n\t{color:#954F72;\r\n\ttext-decoration:underline}\r\np.MsoPlainText, li.MsoPlainText, div.MsoPlainText\r\n\t{margin:0in;\r\n\tmargin-bottom:.0001pt;\r\n\tfont-size:11.0pt;\r\n\tfont-family:\"Calibri\",sans-serif}\r\np.msonormal0, li.msonormal0, div.msonormal0\r\n\t{margin-right:0in;\r\n\tmargin-left:0in;\r\n\tfont-size:12.0pt;\r\n\tfont-family:\"Times New Roman\",serif}\r\nspan.PlainTextChar\r\n\t{font-family:\"Calibri\",sans-serif}\r\nspan.EmailStyle20\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:windowtext}\r\nspan.EmailStyle21\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle22\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle23\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle24\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle25\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle26\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle27\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle28\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle29\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle30\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle31\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle32\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle33\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle34\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle35\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle36\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle37\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle38\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle39\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle40\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle41\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle42\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle43\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle44\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle45\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle46\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle47\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle48\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle49\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle50\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle51\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle52\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle53\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle54\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle55\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle56\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\n.MsoChpDefault\r\n\t{font-size:10.0pt}\r\n@page WordSection1\r\n\t{margin:1.0in 1.0in 1.0in 1.0in}\r\ndiv.WordSection1\r\n\t{}\r\n-->\r\n</style>\r\n</head>\r\n<body lang=\"EN-US\" link=\"#0563C1\" vlink=\"#954F72\">\r\n<div class=\"WordSection1\">\r\n<p class=\"MsoNormal\"><span style=\"color:#1F497D\">&nbsp;</span></p>\r\n<p class=\"MsoNormal\"><span style=\"color:#1F497D\">&nbsp;</span></p>\r\n<div>\r\n<div style=\"border:none; border-top:solid #E1E1E1 1.0pt; padding:3.0pt 0in 0in 0in\">\r\n<p class=\"MsoNormal\"><b>From:</b> Amarendra Kumar <br>\r\n<b>Sent:</b> Thursday, June 14, 2018 3:57 AM<br>\r\n<b>To:</b> Amarendra Kumar &lt;Amarendra.Kumar@mindtree.com&gt;<br>\r\n<b>Subject:</b> RE: ScheduleIn:GDPRBroadcastExtract: 17336: SUCCESS</p>\r\n</div>\r\n</div>\r\n<p class=\"MsoNormal\">&nbsp;</p>\r\n<p class=\"MsoNormal\"><span style=\"color:#1F497D\">&nbsp;</span></p>\r\n<p class=\"MsoNormal\"><span style=\"color:#1F497D\">&nbsp;</span></p>\r\n<div>\r\n<div style=\"border:none; border-top:solid #E1E1E1 1.0pt; padding:3.0pt 0in 0in 0in\">\r\n<p class=\"MsoNormal\"><b>From:</b> Amarendra Kumar <br>\r\n<b>Sent:</b> Monday, June 11, 2018 12:03 PM<br>\r\n<b>To:</b> Amarendra Kumar &lt;<a href=\"mailto:Amarendra.Kumar@mindtree.com\">Amarendra.Kumar@mindtree.com</a>&gt;<br>\r\n<b>Subject:</b> RE: ScheduleIn:GDPRBroadcastExtract: 17336: SUCCESS</p>\r\n</div>\r\n</div>\r\n<p class=\"MsoNormal\">&nbsp;</p>\r\n<p class=\"MsoPlainText\">###############################################</p>\r\n<p class=\"MsoPlainText\">Date:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 2018/02/19 00:00:00</p>\r\n<p class=\"MsoPlainText\">File Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 1CP_GCR06316865_GDPRBroadcastExtract_GBR_Mindtree_DataErase_20180605220102.txt</p>\r\n<p class=\"MsoPlainText\">Status:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; SUCCESS</p>\r\n<p class=\"MsoPlainText\">SFTP Path:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; /data02/outbound/GDPRBroadcast/GBR/Mindtree</p>\r\n<p class=\"MsoPlainText\">Case ID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;GCR00027937</p>\r\n<p class=\"MsoPlainText\">Gdpr Request Type:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; DataErase</p>\r\n<p class=\"MsoPlainText\">###############################################</p>\r\n<p class=\"MsoNormal\">&nbsp;</p>\r\n</div>\r\n</body>\r\n</html>\r\n";


            //    string emailBodyContent = "< html >\r\n < head >\r\n < meta http - equiv =\"Content-Type\" content=\"text/html; charset=utf-8\">\r\n<meta content=\"text/html; charset=us-ascii\">\r\n<meta name=\"Generator\" content=\"Microsoft Word 15 (filtered medium)\">\r\n<style>\r\n<!--\r\n@font-face\r\n\t{font-family:\"Cambria Math\"}\r\n@font-face\r\n\t{font-family:Calibri}\r\np.MsoNormal, li.MsoNormal, div.MsoNormal\r\n\t{margin:0in;\r\n\tmargin-bottom:.0001pt;\r\n\tfont-size:11.0pt;\r\n\tfont-family:\"Calibri\",sans-serif}\r\na:link, span.MsoHyperlink\r\n\t{color:#0563C1;\r\n\ttext-decoration:underline}\r\na:visited, span.MsoHyperlinkFollowed\r\n\t{color:#954F72;\r\n\ttext-decoration:underline}\r\np.MsoPlainText, li.MsoPlainText, div.MsoPlainText\r\n\t{margin:0in;\r\n\tmargin-bottom:.0001pt;\r\n\tfont-size:11.0pt;\r\n\tfont-family:\"Calibri\",sans-serif}\r\np.msonormal0, li.msonormal0, div.msonormal0\r\n\t{margin-right:0in;\r\n\tmargin-left:0in;\r\n\tfont-size:12.0pt;\r\n\tfont-family:\"Times New Roman\",serif}\r\nspan.PlainTextChar\r\n\t{font-family:\"Calibri\",sans-serif}\r\nspan.EmailStyle20\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:windowtext}\r\nspan.EmailStyle21\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle22\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle23\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle24\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle25\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle26\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle27\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle28\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle29\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle30\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\n.MsoChpDefault\r\n\t{font-size:10.0pt}\r\n@page WordSection1\r\n\t{margin:1.0in 1.0in 1.0in 1.0in}\r\ndiv.WordSection1\r\n\t{}\r\n-->\r\n</style>\r\n</head>\r\n<body lang=\"EN-US\" link=\"#0563C1\" vlink=\"#954F72\">\r\n<div class=\"WordSection1\">\r\n<p class=\"MsoNormal\"><span style=\"color:#1F497D\">&nbsp;</span></p>\r\n<p class=\"MsoNormal\"><span style=\"color:#1F497D\">&nbsp;</span></p>\r\n<div>\r\n<div style=\"border:none; border-top:solid #E1E1E1 1.0pt; padding:3.0pt 0in 0in 0in\">\r\n<p class=\"MsoNormal\"><b>From:</b> Amarendra Kumar <br>\r\n<b>Sent:</b> Wednesday, May 30, 2018 5:50 AM<br>\r\n<b>To:</b> Amarendra Kumar &lt;Amarendra.Kumar@mindtree.com&gt;<br>\r\n<b>Subject:</b> RE: ScheduleIn:GDPRBroadcastExtract: 17336: SUCCESS</p>\r\n</div>\r\n</div>\r\n<p class=\"MsoNormal\">&nbsp;</p>\r\n<p class=\"MsoNormal\"><span style=\"color:#1F497D\">&nbsp;</span></p>\r\n<p class=\"MsoNormal\"><span style=\"color:#1F497D\">&nbsp;</span></p>\r\n<div>\r\n<div style=\"border:none; border-top:solid #E1E1E1 1.0pt; padding:3.0pt 0in 0in 0in\">\r\n<p class=\"MsoNormal\"><b>From:</b> Amarendra Kumar <br>\r\n<b>Sent:</b> Wednesday, May 30, 2018 5:13 AM<br>\r\n<b>To:</b> 'gdprrequestbv.im@pg.com' &lt;<a href=\"mailto:gdprrequestbv.im@pg.com\">gdprrequestbv.im@pg.com</a>&gt;<br>\r\n<b>Subject:</b> RE: ScheduleIn:GDPRBroadcastExtract: 17336: SUCCESS</p>\r\n</div>\r\n</div>\r\n<p class=\"MsoNormal\">&nbsp;</p>\r\n<p class=\"MsoPlainText\">###############################################</p>\r\n<p class=\"MsoPlainText\">Date:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 2018/02/19 00:00:00</p>\r\n<p class=\"MsoPlainText\">File Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 1CP_GCR00027937_GDPRBroadcastExtract_GBR_ALL_DataAccess_20180219220004.txt</p>\r\n<p class=\"MsoPlainText\">Status:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; SUCCESS</p>\r\n<p class=\"MsoPlainText\">SFTP Path:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; /data01/home/pgteraprd/pgftp/outbound/GDPRBroadcast/GBR/ALL</p>\r\n<p class=\"MsoPlainText\">Case ID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;GCR00027937</p>\r\n<p class=\"MsoPlainText\">Gdpr Request Type:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; DataAccess</p>\r\n<p class=\"MsoPlainText\">###############################################</p>\r\n<p class=\"MsoNormal\">&nbsp;</p>\r\n</div>\r\n</body>\r\n</html>\r\n";

            // oneCOTextfilePContent
            /*
            string emailBodyContent = @"GDPR_CASE_ID|GDPR_RQST_TYPE_NAME|GVN_NAME|MID_NAME|FAMLY_NAME|NAME_SUFFX_TXT|FULL_NAME|MKTNG_PGM_NBR|REGIS_CNSMR_ID_VAL|DATA_SRCE_NBR|NATIONAL_ID_NBR|EMAIL_ADDR_TXT|FULL_PHONE_NUM|ADDR_LINE_1_TXT|ADDR_LINE_2_TXT|ADDR_LINE_3_TXT|CITY_NAME|TERR_NAME|POSTL_AREA_CODE|CNTRY_CODE|GDPR_RQST_CRTN_DATETM|GDPR_RQST_IDNTY_VFYD_DATETM|REGIS_PRSNA_ID
GCR06224654 | DataErase | PAULINE || FRY ||| 262 | PC25187123 ||||||||||| GBR | 2018 - 05 - 09 05:08:28.000000 | 2018 - 05 - 21 05:34:11.000000 | 568839637
GCR06224654 | DataErase | PAULINE || FRY ||||||| paulineefry@gmail.com | 1666825427 | Bristol Road | The Bull House|| Malmesbury | Wiltshire | SN16 0RA | GBR | 2018 - 05 - 09 05:08:28.000000 | 2018 - 05 - 21 05:34:11.000000 |
                                 GCR06224654 | DataErase | PAULINE || FRY ||| 288 | PC25187123 ||||||||||| GBR | 2018 - 05 - 09 05:08:28.000000 | 2018 - 05 - 21 05:34:11.000000 | 563639298 "; 
            */


            string testEmail = String.Empty; 
             testEmail = "< html >\r\n < head >\r\n < meta http - equiv =\"Content-Type\" content=\"text/html; charset=utf-8\">\r\n<meta content=\"text/html; charset=utf-8\">\r\n</head>\r\n<body>\r\n<p style=\"font-family:Calibri; color:#0000FF\">* You are receiving this mail from an external source *</p>\r\n<p></p>\r\n<div>Bazaarvoice has finished processing your Right of Access request #8717e523-de5f-486b-8096-efdc427cc2da. Data associated with this request will be available for 14 days. .</div>\r\n</body>\r\n</html>\r\n";

            string testEmail2 = "<html>\r\n<head>\r\n<meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\">\r\n<meta content=\"text/html; charset=us-ascii\">\r\n<meta name=\"Generator\" content=\"Microsoft Word 15 (filtered medium)\">\r\n<style>\r\n<!--\r\n@font-face\r\n\t{font-family:\"Cambria Math\"}\r\n@font-face\r\n\t{font-family:Calibri}\r\np.MsoNormal, li.MsoNormal, div.MsoNormal\r\n\t{margin:0in;\r\n\tmargin-bottom:.0001pt;\r\n\tfont-size:11.0pt;\r\n\tfont-family:\"Calibri\",sans-serif}\r\na:link, span.MsoHyperlink\r\n\t{color:#0563C1;\r\n\ttext-decoration:underline}\r\na:visited, span.MsoHyperlinkFollowed\r\n\t{color:#954F72;\r\n\ttext-decoration:underline}\r\np.MsoPlainText, li.MsoPlainText, div.MsoPlainText\r\n\t{margin:0in;\r\n\tmargin-bottom:.0001pt;\r\n\tfont-size:11.0pt;\r\n\tfont-family:\"Calibri\",sans-serif}\r\np.msonormal0, li.msonormal0, div.msonormal0\r\n\t{margin-right:0in;\r\n\tmargin-left:0in;\r\n\tfont-size:12.0pt;\r\n\tfont-family:\"Times New Roman\",serif}\r\nspan.PlainTextChar\r\n\t{font-family:\"Calibri\",sans-serif}\r\nspan.EmailStyle20\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:windowtext}\r\nspan.EmailStyle21\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle22\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle23\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle24\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle25\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle26\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle27\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle28\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle29\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle30\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle31\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle32\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle33\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle34\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle35\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle36\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle37\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle38\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle39\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle40\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle41\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle42\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle43\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle44\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle45\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle46\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle47\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle48\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle49\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:windowtext}\r\nspan.EmailStyle50\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle51\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:windowtext}\r\nspan.EmailStyle52\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle53\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle54\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle55\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle56\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle57\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle58\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle59\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle60\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:windowtext}\r\nspan.EmailStyle61\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle62\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle63\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle64\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle65\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:windowtext}\r\nspan.EmailStyle66\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle67\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:windowtext}\r\nspan.EmailStyle68\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle69\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle70\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle71\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:windowtext}\r\nspan.EmailStyle72\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:#1F497D}\r\nspan.EmailStyle73\r\n\t{font-family:\"Calibri\",sans-serif;\r\n\tcolor:windowtext}\r\n.MsoChpDefault\r\n\t{font-size:10.0pt}\r\n@page WordSection1\r\n\t{margin:1.0in 1.0in 1.0in 1.0in}\r\ndiv.WordSection1\r\n\t{}\r\n-->\r\n</style>\r\n</head>\r\n<body lang=\"EN-US\" link=\"#0563C1\" vlink=\"#954F72\">\r\n<div class=\"WordSection1\">\r\n<p class=\"MsoPlainText\">###############################################</p>\r\n<p class=\"MsoPlainText\">Date:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 2018/02/19 00:00:00</p>\r\n<p class=\"MsoPlainText\">File Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 1CP_GCR06457908_GDPRBroadcastExtract_GBR_Mindtree_DataErase_20180621220018.txt</p>\r\n<p class=\"MsoPlainText\">Status:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; SUCCESS</p>\r\n<p class=\"MsoPlainText\">SFTP Path:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; /data02/outbound/GDPRBroadcast/GBR/Mindtree</p>\r\n<p class=\"MsoPlainText\">Case ID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;GCR06457908</p>\r\n<p class=\"MsoPlainText\">Gdpr Request Type:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; DataErase</p>\r\n<p class=\"MsoPlainText\">###############################################</p>\r\n<p class=\"MsoNormal\">&nbsp;</p>\r\n</div>\r\n<br>\r\n<hr>\r\n<font face=\"Arial\" color=\"Gray\" size=\"1\"><br>\r\nhttp://www.mindtree.com/email/disclaimer.html<br>\r\n</font>\r\n</body>\r\n</html>\r\n";


            //string GDRPEmailBoxIn = Regex.Replace(testEmail, "<.*?>", string.Empty);
            //if (updatedBody.Contains("Bazaarvoice has finished processing your Right of Access request"))
            //{
            //    var statusID = GDRPEmailBoxIn.Substring(GDRPEmailBoxIn.LastIndexOf("#"));
            //    string[] arrayStr = statusID.Split('.');
            //    statusID = arrayStr[0].Replace('#', ' ').Trim();
            //}
            //string zz = "/data02/outbound/GDPRBroadcast/GBR/Mindtree/1CP_GCR06122046_GDPRBroadcastExtract_GBR_Mindtree_DataPortability_20180623035106.txt";

            //string fileNameZ = zz.Substring(zz.LastIndexOf("1CP"));

            //Console.WriteLine(fileNameZ.Split('_')[1].Trim());
            //Console.WriteLine(fileNameZ.Split('_')[5].Trim());

           // string actualEmail = "############################################### \r\nDate:\t\t\t\t2018/09/05 00:00:00\r\nFile Name:\t\t\t1CP_GCR06872638_GDPRBroadcastExtract_DEU_Mindtree_DataErase_20180905220012.txt\r\nStatus:\t\t\t\tSUCCESS\r\nSFTP Path:\t\t\t/data01/home/pgteraprd/pgftp/outbound/GDPRBroadcast/DEU/Mindtree\r\nCase ID:\t\t\tGCR06872638\r\nGdpr Request Type:\t\tDataErase\r\n############################################### \r\n";

            string actualEmail= "############################################### \r\nDate:\t\t\t\t2018/09/18 00:00:00\r\nFile Name:\t\t\t1CP_GCR07066745_GDPRBroadcastExtract_ITA_Mindtree_DataAccess_20180918220022.txt\r\nStatus:\t\t\t\tSUCCESS\r\nSFTP Path:\t\t\t/data01/home/pgteraprd/pgftp/outbound/GDPRBroadcast/ITA/Mindtree\r\nCase ID:\t\t\tGCR07066745\r\nGdpr Request Type:\t\tDataAccess\r\n############################################### \r\n"; 



            string finalStr = GDRPEmailBoxIn.Substring(GDRPEmailBoxIn.LastIndexOf("Date"));

            
            string fileName = finalStr.Substring(finalStr.LastIndexOf("File Name:"));
            fileName = fileName.Substring(0, fileName.LastIndexOf("Status"));
            fileName = fileName.Substring(fileName.LastIndexOf("1CP"));
            int index = 0; 
            index = fileName.IndexOf('<');
            fileName = fileName.Substring(0, index);
            // fileName = fileName.Substring(0, 12); 

            //Console.WriteLine(HtmlRemoval.StripTagsRegex(html));
            //Console.WriteLine(HtmlRemoval.StripTagsRegexCompiled(html));
            //Console.WriteLine(HtmlRemoval.StripTagsCharArray(html));


            //  string[] caseID = finalStr.Split(':')[7].ToString().Split('\r');
            //   string gcrCase = caseID[0].Substring(caseID[0].LastIndexOf("GCR"));

            string[] caseID = fileName.Split('_');
            string gcrCase = caseID[1].ToString().Trim(); 

        //    string[] caseID = finalStr.Split(':')[7].ToString().Split('\r');
        //string gcrCase = caseID[0].Replace("&nbsp;", "").Replace("</p>", "");
           // index = 0;
           // index = gcrCase.IndexOf('<');
           
           //gcrCase = gcrCase.Substring(0, index);  //caseID[0].Trim();


            string SFTPPath = finalStr.Substring(finalStr.LastIndexOf("SFTP Path:"));
            SFTPPath = SFTPPath.Substring(0, SFTPPath.LastIndexOf("Case ID"));
            SFTPPath = SFTPPath.Substring(SFTPPath.LastIndexOf("mnt")).Trim();
            index = 0;
            index = SFTPPath.IndexOf('<');
            SFTPPath = SFTPPath.Substring(0, index);



            // ****    Works with HTML EMAIL used in development **********  

            /*
            string finalStr = actualEmail.Substring(actualEmail.LastIndexOf("Date"));

            string fileName = finalStr.Substring(finalStr.LastIndexOf("File Name:"));
            fileName = fileName.Substring(0, fileName.LastIndexOf("Status"));
            fileName = fileName.Substring(fileName.LastIndexOf("1CP"));

            string[] caseID = finalStr.Split(':')[7].ToString().Split('\r');
            string gcrCase = caseID[0].Substring(caseID[0].LastIndexOf("GCR"));

            string SFTPPath = finalStr.Substring(finalStr.LastIndexOf("SFTP Path:"));
            SFTPPath = SFTPPath.Substring(0, SFTPPath.LastIndexOf("Case ID"));
            SFTPPath = SFTPPath.Substring(SFTPPath.LastIndexOf("data01"));  // ** update date01 to a dynamic value **

            SFTPPath = SFTPPath.Substring(SFTPPath.LastIndexOf("data02"));  // ** Prod SFTp starts with data02 **
            */

            var oneCPFilePath = SFTPPath + @"/" + fileName; // Return cleaned text
            oneCPFilePath = oneCPFilePath.Replace("\r\n", "");
            var path = oneCPFilePath.Insert(0, "/");

            

            //  ************** FOr Testing Purpose Only     ********************

            string[] arrayPAth = path.Split('/'); 
            string finalPath = "/data02/"+ arrayPAth[5] + "/" + arrayPAth[6] + "/" + arrayPAth[7] + "/" + arrayPAth[8] + "/" + arrayPAth[9];

            // /data01/home/pgteraprd/pgftp/outbound/GDPRBroadcast/GBR/ALL

            

            /*  Date Commented - 31st August 2018 - Soft Launch Date


            string finalStr = GDRPEmailBoxIn.Substring(GDRPEmailBoxIn.LastIndexOf("Date"));

            string fileName = finalStr.Substring(finalStr.LastIndexOf("File Name:"));
            fileName = fileName.Substring(0, fileName.LastIndexOf("Status"));
            fileName = fileName.Substring(fileName.LastIndexOf("1CP"));

            string SFTPPath = finalStr.Substring(finalStr.LastIndexOf("SFTP Path:"));
            SFTPPath = SFTPPath.Substring(0, SFTPPath.LastIndexOf("Case ID"));
            SFTPPath = SFTPPath.Substring(SFTPPath.LastIndexOf("data02"));  // ** update date01 to a dynamic value **
            
            */

            /*
              string caseID = null;
              string gdprRequestType = null;
              string userEmail = null;
              string authorID = null;
              string countryCode = null;
              string userEmailID = null;

              for (int y = 0; y < (emailBodyContent.Length); y++)
              {
                  string[] columns = emailBodyContent.Split('|');
                  //To ignore the Case sensitivity result_DP and result_DA variables are used.
                  int result_DP = string.Compare(columns[1], "DataPortability", true);
                  int result_DA = string.Compare(columns[1], "DataAccess", true);

                  // Perform the Operation only if the STrings are matching
                  if (result_DP == 0) // if request type is data Portability
                  {
                      caseID = columns[0];
                      gdprRequestType = columns[1];
                      authorID = columns[8];
                      userEmail = columns[11];
                      countryCode = "TOBEUPDATED"; //   ** country code needs to be mapped 
                      userEmailID = userEmail;
                  }
                  else if (result_DA == 0)   // request type if Data access
                  {
                      caseID = columns[0];
                      gdprRequestType = columns[1];
                      authorID = columns[8];
                      userEmail = columns[11];
                      userEmailID = userEmail;
                  }
                  else   // Delete requests 
                  {
                      caseID = columns[0];
                      gdprRequestType = columns[1];
                      authorID = columns[8];
                      userEmail = columns[11];
                      userEmailID = userEmail;
                  }
              }

              */

            //string oneCPFilePath = SFTPPath + @"/" + fileName; // Return cleaned text

            //oneCPFilePath = oneCPFilePath.Replace("\r\n", "");
            //var Path = oneCPFilePath.Insert(0, "/");
            //Console.WriteLine(oneCPFilePath);         

            // Console.WriteLine(userEmailID);

        }
    }
}
