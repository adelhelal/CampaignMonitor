<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Javascript.UnitTest.aspx.cs" Inherits="CodeTest.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Javascript Requirements</title>
    <link href="common/Qunit/qunit-1.14.0.css" rel="stylesheet" />
    <script type="text/javascript" src="common/Qunit/qunit-1.14.0.js"></script>
    <script type="text/javascript" src="common/JQuery/jquery-1.9.1.js"></script>
    <script type="text/javascript" src="Javascript/Requirements5.js"></script>
    <script type="text/javascript" src="Javascript/Requirements6.js"></script>
    <script type="text/javascript" src="Javascript/Requirements7.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>Requirement 5 & 6</h2>

        <!-- Using Qunit to test the extention methods in Javascript/Requirements5.js -->   
        <div id="qunit"></div>
        <div id="qunit-fixture"></div>

        <script type="text/javascript">

            // Requirement 5

            var requirements5 = new String('hang the dj');

            test('Requirements 5 - TRUE "hang the dj" .startsWith("hang")', function () { ok(requirements5.startsWith('hang')); });
            test('Requirements 5 - FALSE "hang the dj" .startsWith("Hang")', function () { ok(!requirements5.startsWith('Hang')); });
            test('Requirements 5 - FALSE "hang the dj" .startsWith("I\'ve got a room for rent")', function () { ok(!requirements5.startsWith("I've got a room for rent")); });
            test('Requirements 5 - TRUE "hang the dj" .startsWith("")', function () { ok(requirements5.startsWith('')); });
            test('Requirements 5 - TRUE "hang the dj" .startsWith("hang the")', function () { ok(requirements5.startsWith('hang the')); });
            test('Requirements 5 - FALSE "hang the dj" .startsWith(42)', function () { ok(!requirements5.startsWith(42)); });
            test('Requirements 5 - FALSE "hang the dj" .startsWith({ first: "Johnny" })', function () { ok(!requirements5.startsWith({ first: 'Johnny' })); });

            test('Requirements 5 - TRUE "hang the dj" .endsWith("dj")', function () { ok(requirements5.endsWith('dj')); });
            test('Requirements 5 - FALSE "hang the dj" .endsWith("panic on the streets")', function () { ok(!requirements5.endsWith('panic on the streets')); });
            test('Requirements 5 - TRUE "hang the dj" .endsWith("")', function () { ok(requirements5.endsWith('')); });
            test('Requirements 5 - TRUE "hang the dj" .endsWith("the dj")', function () { ok(requirements5.endsWith('the dj')); });
            test('Requirements 5 - FALSE "hang the dj" .endsWith(42)', function () { ok(!requirements5.endsWith(42)); });
            test('Requirements 5 - FALSE "hang the dj" .endsWith({ first: "Johnny" })', function () { ok(!requirements5.endsWith({ first: 'Johnny' })); });

            // Requirement 6

            var requirements6a = new String('<p>Shoplifters of the World <em>Unite</em>!</p>');

            test('Requirements 6 - TRUE - Strip HTML', function () { strictEqual(requirements6a.stripHtml(), 'Shoplifters of the World Unite!'); });

            var requirements6b = new String('1 &lt; 2');

            test('Requirements 6 - TRUE - Strip HTML from "1 &lt; 2"', function () { strictEqual(requirements6b.stripHtml(), '1 &lt; 2'); });

            var requirements6c = new String('<script type="text/javascript">alert("hi");<\/script>');

            test('Requirements 6 - TRUE - Strip HTML from script tag', function () { strictEqual(requirements6c.stripHtml(), 'alert("hi");'); });

            var requirements6d = new String('<!DOCTYPE html><html xmlns="http://www.w3.org/1999/xhtml"><head><title>Javascript Requirements</title></head><body><div></div></body></html>');

            test('Requirements 6 - TRUE - Strip HTML from full document', function () { strictEqual(requirements6d.stripHtml(), 'Javascript Requirements'); });

        </script>

        <h2>Requirements 7</h2>

        <!-- 
            Anchor tag links with the class name "popup-link" will be hooked into the JQuery plugin found in Javascript/Requirements7.js
            hrefs are replaced with onclick events that call windows.open()
            An "option" attribute is also added to adjust settings of window. Option properties can be found here: http://www.w3schools.com/jsref/met_win_open.asp
        -->

        <h3>Popup links</h3>

        <a class="popup-link" data-window-group="google" option="width=800,height=500,top=200,resizable=no,scrollbars=no" href="http://google.com">Google</a> (data-window-group="google")
        <br />
        <a class="popup-link" data-window-group="google" href="http://mail.google.com">Gmail</a> (data-window-group="google")
        <br />
        <a class="popup-link" data-window-group="google" href="http://plus.google.com">Google+</a> (data-window-group="google")
        <br />
        <a class="popup-link" data-window-group="microsoft" href="http://microsoft.com">Microsoft</a> (data-window-group="microsoft")
        <br />
        <a class="popup-link" data-window-group="microsoft" href="http://ninemsn.com.au">ninemsn</a> (data-window-group="microsoft")
        <br />
        <a class="popup-link" data-window-group="microsoft" href="http://live.com">Live Mail</a> (data-window-group="microsoft")
        <br />
        <a class="popup-link" data-window-group="yahoo" href="http://yahoo.com">Yahoo</a> (data-window-group="yahoo")

        <h3>Normal links not affected by JQuery plugin</h3>

        <a href="http://www.campaignmonitor.com/">Campaign Monitor</a>
        <br />
        <a href="http://www.seek.com.au/">Seek</a>

    </div>
    </form>
</body>
</html>
