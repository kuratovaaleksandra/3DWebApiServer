﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Web.Helpers
{
    using System;
    using System.Collections.Generic;
    
    #line 3 "Twitter.cshtml"
    using System.Globalization;
    
    #line default
    #line hidden
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using System.Web.WebPages.Html;
    
    #line 4 "Twitter.cshtml"
    using Microsoft.Internal.Web.Utils;
    
    #line default
    #line hidden
    
    public class Twitter : System.Web.WebPages.HelperPage
    {

public static System.Web.WebPages.HelperResult TweetButton(
            string dataCount = "vertical",
            string shareText = "Tweet",
            string tweetText = "",
            string url = "",
            string language = "",
            string userName = "",
            string relatedUserName = "",
            string relatedUserDescription = "") {
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {



#line 14 "Twitter.cshtml"
                                                 
    var tweetTextAttribute = new HtmlString(!tweetText.IsEmpty() ? String.Format(CultureInfo.InvariantCulture, " data-text=\"{0}\"", HttpUtility.HtmlAttributeEncode(tweetText)) : "");
    var urlAttribute = new HtmlString(!url.IsEmpty() ? String.Format(CultureInfo.InvariantCulture, " data-url=\"{0}\"", HttpUtility.HtmlAttributeEncode(url)) : "");
    var languageAttribute = new HtmlString(!language.IsEmpty() && !language.Equals("en", StringComparison.OrdinalIgnoreCase) ? String.Format(CultureInfo.InvariantCulture, " data-lang=\"{0}\"", HttpUtility.HtmlAttributeEncode(language)) : "");
    var userNameAttribute = new HtmlString(!userName.IsEmpty() ? String.Format(CultureInfo.InvariantCulture, " data-via=\"{0}\"", HttpUtility.HtmlAttributeEncode(userName)) : "");
    var relatedAttribute = new HtmlString(!relatedUserName.IsEmpty() ? String.Format(CultureInfo.InvariantCulture, " data-related=\"{0}{1}\"", HttpUtility.HtmlAttributeEncode(relatedUserName), 
        !relatedUserDescription.IsEmpty() ? ":" + HttpUtility.HtmlAttributeEncode(relatedUserDescription) : "") : "");

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "<a href=\"http://twitter.com/share\" class=\"twitter-share-button\"");



#line 21 "Twitter.cshtml"
                                WriteTo(@__razor_helper_writer, tweetTextAttribute);

#line default
#line hidden



#line 21 "Twitter.cshtml"
                                                   WriteTo(@__razor_helper_writer, urlAttribute);

#line default
#line hidden



#line 21 "Twitter.cshtml"
                                                                WriteTo(@__razor_helper_writer, languageAttribute);

#line default
#line hidden



#line 21 "Twitter.cshtml"
                                                                                  WriteTo(@__razor_helper_writer, userNameAttribute);

#line default
#line hidden



#line 21 "Twitter.cshtml"
                                                                                                    WriteTo(@__razor_helper_writer, relatedAttribute);

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, " data-count=\"");



#line 21 "Twitter.cshtml"
                                                                                                                                  WriteTo(@__razor_helper_writer, dataCount.ToString(CultureInfo.InvariantCulture).ToLowerInvariant());

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\">");



#line 21 "Twitter.cshtml"
                                                                                                                                                                                                        WriteTo(@__razor_helper_writer, shareText);

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "</a>");



WriteLiteralTo(@__razor_helper_writer, "<script type=\"text/javascript\" src=\"http://platform.twitter.com/widgets.js\"></scr" +
"ipt>\r\n");



#line 22 "Twitter.cshtml"

#line default
#line hidden

});

}


public static System.Web.WebPages.HelperResult FollowButton(
            string userName,
            string followStyle = "follow_me",
            string followColor = "a") {
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {



#line 27 "Twitter.cshtml"
                                       

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "<a href=\"http://www.twitter.com/");



#line 28 "Twitter.cshtml"
 WriteTo(@__razor_helper_writer, HttpUtility.UrlEncode(userName));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\"><img src=\"http://twitter-badges.s3.amazonaws.com/");



#line 28 "Twitter.cshtml"
                                                                                     WriteTo(@__razor_helper_writer, HttpUtility.UrlEncode(followStyle + '-' + followColor));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, ".png\" alt=\"Follow ");



#line 28 "Twitter.cshtml"
                                                                                                                                                               WriteTo(@__razor_helper_writer, userName);

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, " on Twitter\"/></a>\r\n");



#line 29 "Twitter.cshtml"

#line default
#line hidden

});

}


public static System.Web.WebPages.HelperResult Profile(
            string userName,
            int width = 250,
            int height = 300,
            string backgroundShellColor = "#333333",
            string shellColor = "#ffffff",
            string tweetsBackgroundColor = "#000000",
            string tweetsColor = "#ffffff",
            string tweetsLinksColor = "#4aed05",
            int numberOfTweets = 4,
            bool scrollBar = false,
            bool loop = false,
            bool live = false,
            bool hashTags = true,
            bool timestamp = true,
            bool avatars = false,
            string behavior = "default",
            int interval = 6) {
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {



#line 48 "Twitter.cshtml"
                               

    if (String.IsNullOrEmpty(userName)) {
        throw new ArgumentException(String.Format(CultureInfo.CurrentUICulture, CommonResources.Argument_Cannot_Be_Null_Or_Empty, "userName"), "userName");
    }


#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "<script type=\"text/javascript\" src=\"http://widgets.twimg.com/j/2/widget.js\"></scr" +
"ipt>\r\n");



WriteLiteralTo(@__razor_helper_writer, "<script type=\"text/javascript\">\r\nnew TWTR.Widget({\r\n  version: 2,\r\n  type: \'profi" +
"le\',\r\n  rpp: ");



#line 59 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, numberOfTweets < 1 ? 1 : (numberOfTweets > 30 ? 30 : numberOfTweets));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, ",\r\n  interval: ");



#line 60 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, interval < 2 ? 2000 : (interval > 20 ? 20000 : (interval * 1000)));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, ",\r\n  width: ");



#line 61 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, new HtmlString(width <= 0 ? "'auto'" : width.ToString(CultureInfo.InvariantCulture)));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, ",\r\n  height: ");



#line 62 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, height < 0 ? "0" : height.ToString(CultureInfo.InvariantCulture));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, ",\r\n  theme: {\r\n    shell: {\r\n      background: \'");



#line 65 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, RawJS(backgroundShellColor.IsEmpty() ? "#333333" : backgroundShellColor));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\',\r\n      color: \'");



#line 66 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, RawJS(shellColor.IsEmpty() ? "#ffffff" : shellColor));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\'\r\n    },\r\n    tweets: {\r\n      background: \'");



#line 69 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, RawJS(tweetsBackgroundColor.IsEmpty() ? "#000000" : tweetsBackgroundColor));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\',\r\n      color: \'");



#line 70 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, RawJS(tweetsColor.IsEmpty() ? "#ffffff" : tweetsColor));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\',\r\n      links: \'");



#line 71 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, RawJS(tweetsLinksColor.IsEmpty() ? "#4aed05" : tweetsLinksColor));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\'\r\n    }\r\n  },\r\n  features: {\r\n    scrollbar: ");



#line 75 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, scrollBar.ToString(CultureInfo.InvariantCulture).ToLowerInvariant());

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, ",\r\n    loop: ");



#line 76 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, loop.ToString(CultureInfo.InvariantCulture).ToLower(CultureInfo.InvariantCulture));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, ",\r\n    live: ");



#line 77 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, live.ToString(CultureInfo.InvariantCulture).ToLower(CultureInfo.InvariantCulture));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, ",\r\n    hashtags: ");



#line 78 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, hashTags.ToString(CultureInfo.InvariantCulture).ToLower(CultureInfo.InvariantCulture));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, ",\r\n    timestamp: ");



#line 79 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, timestamp.ToString(CultureInfo.InvariantCulture).ToLowerInvariant());

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, ",\r\n    avatars: ");



#line 80 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, avatars.ToString(CultureInfo.InvariantCulture).ToLowerInvariant());

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, ",\r\n    behavior: \'");



#line 81 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, behavior.ToString(CultureInfo.InvariantCulture).ToLowerInvariant());

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\'\r\n  }\r\n}).render().setUser(\'");



#line 83 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, RawJS(userName));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\').start();\r\n</script>\r\n");



#line 85 "Twitter.cshtml"

#line default
#line hidden

});

}


public static System.Web.WebPages.HelperResult Search(
            string searchQuery,
            int width = 250,
            int height = 300,
            string title = null,
            string caption = null,
            string backgroundShellColor = "#8ec1da",
            string shellColor = "#ffffff",
            string tweetsBackgroundColor = "#ffffff",
            string tweetsColor = "#444444",
            string tweetsLinksColor = "#1985b5",
            bool scrollBar = false,
            bool loop = true,
            bool live = true,
            bool hashTags = true,
            bool timestamp = true,
            bool avatars = true,
            bool topTweets = true,
            string behavior = "default",
            int interval = 6) {
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {



#line 107 "Twitter.cshtml"
                               
     
    if (String.IsNullOrEmpty(searchQuery)) {
        throw new ArgumentException(String.Format(CultureInfo.CurrentUICulture, CommonResources.Argument_Cannot_Be_Null_Or_Empty, "searchQuery"), "searchQuery");
    }


#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "<script type=\"text/javascript\" src=\"http://widgets.twimg.com/j/2/widget.js\"></scr" +
"ipt>\r\n");



WriteLiteralTo(@__razor_helper_writer, "<script type=\"text/javascript\">\r\nnew TWTR.Widget({\r\n  version: 2,\r\n  type: \'searc" +
"h\',\r\n  search: \'");



#line 118 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, RawJS(searchQuery));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\',\r\n  interval: ");



#line 119 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, Math.Min(Math.Max(2, interval), 20) * 1000);

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, ",\r\n  title: \'");



#line 120 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, RawJS(title));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\',\r\n  subject: \'");



#line 121 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, RawJS(caption));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\',\r\n  width: ");



#line 122 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, new HtmlString(width <= 0 ? "'auto'" : width.ToString(CultureInfo.InvariantCulture)));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, ",\r\n  height: ");



#line 123 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, height < 0 ? "0" : height.ToString(CultureInfo.InvariantCulture));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, ",\r\n  theme: {\r\n    shell: {\r\n      background: \'");



#line 126 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, RawJS(backgroundShellColor.IsEmpty() ? "#8ec1da" : backgroundShellColor));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\',\r\n      color: \'");



#line 127 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, RawJS(shellColor.IsEmpty() ? "#ffffff" : shellColor));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\'\r\n    },\r\n    tweets: {\r\n      background: \'");



#line 130 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, RawJS(tweetsBackgroundColor.IsEmpty() ? "#ffffff" : tweetsBackgroundColor));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\',\r\n      color: \'");



#line 131 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, RawJS(tweetsColor.IsEmpty() ? "#444444" : tweetsColor));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\',\r\n      links: \'");



#line 132 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, RawJS(tweetsLinksColor.IsEmpty() ? "#1985b5" : tweetsLinksColor));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\'\r\n    }\r\n  },\r\n  features: {\r\n    scrollbar: ");



#line 136 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, scrollBar.ToString(CultureInfo.InvariantCulture).ToLowerInvariant());

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, ",\r\n    loop: ");



#line 137 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, loop.ToString(CultureInfo.InvariantCulture).ToLowerInvariant());

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, ",\r\n    live: ");



#line 138 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, live.ToString(CultureInfo.InvariantCulture).ToLowerInvariant());

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, ",\r\n    hashtags: ");



#line 139 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, hashTags.ToString(CultureInfo.InvariantCulture).ToLowerInvariant());

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, ",\r\n    timestamp: ");



#line 140 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, timestamp.ToString(CultureInfo.InvariantCulture).ToLowerInvariant());

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, ",\r\n    avatars: ");



#line 141 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, avatars.ToString(CultureInfo.InvariantCulture).ToLowerInvariant());

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, ",\r\n    toptweets: ");



#line 142 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, topTweets.ToString(CultureInfo.InvariantCulture).ToLowerInvariant());

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, ",\r\n    behavior: \'");



#line 143 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, behavior.ToString(CultureInfo.InvariantCulture).ToLowerInvariant());

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\'\r\n  }\r\n}).render().start();\r\n</script>\r\n");



#line 147 "Twitter.cshtml"

#line default
#line hidden

});

}


public static System.Web.WebPages.HelperResult Faves(
            string userName,
            int width = 250,
            int height = 300,
            string title = null,
            string caption = null,
            string backgroundShellColor = "#43c43f",
            string shellColor = "#ffffff",
            string tweetsBackgroundColor = "#ffffff",
            string tweetsColor = "#444444",
            string tweetsLinksColor = "#43c43f",
            int numberOfTweets = 10,
            bool scrollBar = true,
            bool loop = false,
            bool live = true,
            bool hashTags = true,
            bool timestamp = true,
            bool avatars = true,
            string behavior = "default",
            int interval = 6) {
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {



#line 168 "Twitter.cshtml"
                               

    if (String.IsNullOrEmpty(userName)) {
        throw new ArgumentException(String.Format(CultureInfo.CurrentUICulture, CommonResources.Argument_Cannot_Be_Null_Or_Empty, "userName"), "userName");
    }
    

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "<script type=\"text/javascript\" src=\"http://widgets.twimg.com/j/2/widget.js\"></scr" +
"ipt>\r\n");



WriteLiteralTo(@__razor_helper_writer, "<script type=\"text/javascript\">\r\nnew TWTR.Widget({\r\n  version: 2,\r\n  type: \'faves" +
"\',\r\n  rpp: ");



#line 179 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, numberOfTweets < 1 ? 1 : (numberOfTweets > 20 ? 20 : numberOfTweets));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, ",\r\n  interval: ");



#line 180 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, interval < 2 ? 2000 : (interval > 20 ? 20000 : (interval * 1000)));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, ",\r\n  title: \'");



#line 181 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, RawJS(title));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\',\r\n  subject: \'");



#line 182 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, RawJS(caption));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\',\r\n  width: ");



#line 183 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, new HtmlString(width <= 0 ? "'auto'" : width.ToString(CultureInfo.InvariantCulture)));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, ",\r\n  height: ");



#line 184 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, height < 0 ? "0" : height.ToString(CultureInfo.InvariantCulture));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, ",\r\n  theme: {\r\n    shell: {\r\n      background: \'");



#line 187 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, RawJS(backgroundShellColor.IsEmpty() ? "#43c43f" : backgroundShellColor));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\',\r\n      color: \'");



#line 188 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, RawJS(shellColor.IsEmpty() ? "#ffffff" : shellColor));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\'\r\n    },\r\n    tweets: {\r\n      background: \'");



#line 191 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, RawJS(tweetsBackgroundColor.IsEmpty() ? "#ffffff" : tweetsBackgroundColor));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\',\r\n      color: \'");



#line 192 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, RawJS(tweetsColor.IsEmpty() ? "#444444" : tweetsColor));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\',\r\n      links: \'");



#line 193 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, RawJS(tweetsLinksColor.IsEmpty() ? "#43c43f" : tweetsLinksColor));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\'\r\n    }\r\n  },\r\n  features: {\r\n    scrollbar: ");



#line 197 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, scrollBar.ToString(CultureInfo.InvariantCulture).ToLowerInvariant());

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, ",\r\n    loop: ");



#line 198 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, loop.ToString(CultureInfo.InvariantCulture).ToLowerInvariant());

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, ",\r\n    live: ");



#line 199 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, live.ToString(CultureInfo.InvariantCulture).ToLowerInvariant());

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, ",\r\n    hashtags: ");



#line 200 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, hashTags.ToString(CultureInfo.InvariantCulture).ToLowerInvariant());

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, ",\r\n    timestamp: ");



#line 201 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, timestamp.ToString(CultureInfo.InvariantCulture).ToLowerInvariant());

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, ",\r\n    avatars: ");



#line 202 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, avatars.ToString(CultureInfo.InvariantCulture).ToLowerInvariant());

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, ",\r\n    behavior: \'");



#line 203 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, behavior.ToString(CultureInfo.InvariantCulture).ToLowerInvariant());

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\'\r\n  }\r\n}).render().setUser(\'");



#line 205 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, RawJS(userName));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\').start();\r\n</script>\r\n");



#line 207 "Twitter.cshtml"

#line default
#line hidden

});

}


public static System.Web.WebPages.HelperResult List(
            string userName,
            string list,
            int width = 250,
            int height = 300,
            string title = null,
            string caption = null,
            string backgroundShellColor = "#ff96e7",
            string shellColor = "#ffffff",
            string tweetsBackgroundColor = "#ffffff",
            string tweetsColor = "#444444",
            string tweetsLinksColor = "#b740c2",
            int numberOfTweets = 30,
            bool scrollBar = true,
            bool loop = false,
            bool live = true,
            bool hashTags = true,
            bool timestamp = true,
            bool avatars = true,
            string behavior = "default",
            int interval = 6) {
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {



#line 229 "Twitter.cshtml"
                               

    if (String.IsNullOrEmpty(userName)) {
        throw new ArgumentException(String.Format(CultureInfo.CurrentUICulture, CommonResources.Argument_Cannot_Be_Null_Or_Empty, "userName"), "userName");
    }
    
    if (String.IsNullOrEmpty(list)) {
        throw new ArgumentException(String.Format(CultureInfo.CurrentUICulture, CommonResources.Argument_Cannot_Be_Null_Or_Empty, "list"), "list");
    }
    

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "<script type=\"text/javascript\" src=\"http://widgets.twimg.com/j/2/widget.js\"></scr" +
"ipt>\r\n");



WriteLiteralTo(@__razor_helper_writer, "<script type=\"text/javascript\">\r\nnew TWTR.Widget({\r\n  version: 2,\r\n  type: \'list\'" +
",\r\n  rpp: ");



#line 244 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, numberOfTweets < 1 ? 1 : (numberOfTweets > 100 ? 100 : numberOfTweets));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, ",\r\n  interval: ");



#line 245 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, interval < 2 ? 2000 : (interval > 20 ? 20000 : (interval * 1000)));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, ",\r\n  title: \'");



#line 246 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, RawJS(title));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\',\r\n  subject: \'");



#line 247 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, RawJS(caption));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\',\r\n  width: ");



#line 248 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, new HtmlString(width <= 0 ? "'auto'" : width.ToString(CultureInfo.InvariantCulture)));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, ",\r\n  height: ");



#line 249 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, height < 0 ? "0" : height.ToString(CultureInfo.InvariantCulture));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, ",\r\n  theme: {\r\n    shell: {\r\n      background: \'");



#line 252 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, RawJS(backgroundShellColor.IsEmpty() ? "#ff96e7" : backgroundShellColor));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\',\r\n      color: \'");



#line 253 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, RawJS(shellColor.IsEmpty() ? "#ffffff" : shellColor));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\'\r\n    },\r\n    tweets: {\r\n      background: \'");



#line 256 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, RawJS(tweetsBackgroundColor.IsEmpty() ? "#ffffff" : tweetsBackgroundColor));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\',\r\n      color: \'");



#line 257 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, RawJS(tweetsColor.IsEmpty() ? "#444444" : tweetsColor));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\',\r\n      links: \'");



#line 258 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, RawJS(tweetsLinksColor.IsEmpty() ? "#b740c2" : tweetsLinksColor));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\'\r\n    }\r\n  },\r\n  features: {\r\n    scrollbar: ");



#line 262 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, scrollBar.ToString(CultureInfo.InvariantCulture).ToLowerInvariant());

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, ",\r\n    loop: ");



#line 263 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, loop.ToString(CultureInfo.InvariantCulture).ToLowerInvariant());

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, ",\r\n    live: ");



#line 264 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, live.ToString(CultureInfo.InvariantCulture).ToLowerInvariant());

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, ",\r\n    hashtags: ");



#line 265 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, hashTags.ToString(CultureInfo.InvariantCulture).ToLowerInvariant());

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, ",\r\n    timestamp: ");



#line 266 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, timestamp.ToString(CultureInfo.InvariantCulture).ToLowerInvariant());

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, ",\r\n    avatars: ");



#line 267 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, avatars.ToString(CultureInfo.InvariantCulture).ToLowerInvariant());

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, ",\r\n    behavior: \'");



#line 268 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, behavior.ToString(CultureInfo.InvariantCulture).ToLowerInvariant());

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\'\r\n  }\r\n}).render().setList(\'");



#line 270 "Twitter.cshtml"
WriteTo(@__razor_helper_writer, RawJS(userName));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\', \'");



#line 270 "Twitter.cshtml"
          WriteTo(@__razor_helper_writer, RawJS(list));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\').start();\r\n</script>\r\n");



#line 272 "Twitter.cshtml"

#line default
#line hidden

});

}


        #line 275 "Twitter.cshtml"

    private static IHtmlString RawJS(string text) {
        return new HtmlString(HttpUtility.JavaScriptStringEncode(text));
    }

        #line default
        #line hidden

        public Twitter()
        {
        }
    }
}
#pragma warning restore 1591
