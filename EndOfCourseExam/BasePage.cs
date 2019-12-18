namespace EndOfCourseExam
{
    public abstract class BasePage
    {
        public BasePage(string pageName)
        {
            this.PageName = pageName;
        }

        public string PageName { get; protected set; }
    }
}
