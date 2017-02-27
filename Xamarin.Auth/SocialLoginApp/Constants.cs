namespace SocialLoginApp
{
    internal class Constants
    {
        //** Application strings **//
        public const string WAIT = "Please wait.";
        public const string USERNAME = "name";
        public const string HELLO = "Hello ";
        public const string REST_TYPE = "GET";
        public const string CHECKING_INFO = "Checking user Info..";
        public const string SERVICE_ID = "userdata";
        public const string USER_KEY = "userkey";
        public const string WELCOME = "Welcome ";
        public const string LOGGED_OUT = "You are LoggedOut!!";
        public const string FAIL_AUTH = "Authentication is cancelled!";
        public const string GMAIL = "Gmail";
        public const string FACEBOOK = "Facebook";
        public const string MICROSOFT = "Microsoft";

        //** For Facebook **//
        public const string FB_APPID = "Your Id here";
        public const string FB_SCOPE = "";
        public const string FB_AUTHURL = "https://m.facebook.com/dialog/oauth/";
        public const string FB_REDIRECTURL = "http://www.facebook.com/connect/login_success.html";
        public const string FB_REQUESTURL = "https://graph.facebook.com/me?fields=id,name,email,picture.type(large)";

        //** For Twitter **//
        public const string TWITTER_KEY = "Your key here";
        public const string TWITTE_SECRET = "Your secret here";
        public const string TWITTE_REQ_TOKEN = "https://api.twitter.com/oauth/request_token";
        public const string TWITTER_AUTH = "https://api.twitter.com/oauth/authorize";
        public const string TWITTER_ACCESS_TOKEN = "https://api.twitter.com/oauth/access_token";
        public const string TWITTE_CALLBACKURL = "http://mobile.twitter.com";
        public const string TWITTER_REQUESTURL = "https://api.twitter.com/1.1/account/verify_credentials.json";

        //** For Gmail **//
        public const string GMAIL_ID = "***********.apps.googleusercontent.com";
        public const string GMAIL_SCOPE = "https://www.googleapis.com/auth/userinfo.email";
        public const string GMAIL_AUTH = "https://accounts.google.com/o/oauth2/auth";
        public const string GMAIL_REDIRECTURL = "https://www.googleapis.com/plus/v1/people/me";
        public const string GMAIL_REQUESTURL = "https://www.googleapis.com/oauth2/v2/userinfo";

        //** For Microsoft **//
        public const string MS_ID = "Your Id here";
        public const string MS_SCOPE = "https://graph.microsoft.com/user.read";
        public const string MS_AUTHURL = "https://login.microsoftonline.com/common/oauth2/V2.0/authorize";
        public const string MS_REDIRECTURL = "urn:ietf:wg:oauth:2.0:oob";
        public const string MS_REQUESTURL = "https://graph.microsoft.com/v1.0/me";
    }
}
