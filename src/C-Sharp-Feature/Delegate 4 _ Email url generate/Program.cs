using Delegate_4___Email_url_generate;

string GenerateLink(int campaignId, string email)
{
    return $"https://mypage.com/campaign/track?c={campaignId}&e={email}";
}

var emailSender = new EmailSender();
emailSender.SendBulkEmail(1, new List<string> { "faisal.exe@gmail.com", "salman.exe@gmail.com" }, GenerateLink);
