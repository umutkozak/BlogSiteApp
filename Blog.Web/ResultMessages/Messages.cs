namespace Blog.Web.ResultMessages
{
    public static class Messages
    {
        public static string Add(string articleTitle)
        {
            return $"{articleTitle} başlıklı makale başarıyla eklenmiştir.";
            
        }
        public static string Update(string articleTitle)
        {
            return $"{articleTitle} başlıklı makale başarıyla güncellenmiştir.";

        }
    }
}
