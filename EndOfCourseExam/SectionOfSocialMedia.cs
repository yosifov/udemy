namespace EndOfCourseExam
{
    public class SectionOfSocialMedia
    {
        public SectionOfSocialMedia(Element twitterButton, Element facebookButton)
        {
            this.TwitterButton = twitterButton;
            this.FacebookButton = facebookButton;
        }

        public Element TwitterButton { get; private set; }

        public Element FacebookButton { get; private set; }
    }
}
