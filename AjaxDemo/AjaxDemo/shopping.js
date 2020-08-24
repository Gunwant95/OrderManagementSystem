var ajax = false;
if (window.XMLHttpRequest) {
    ajax = new XMLHttpRequest();
}
else if (window.ActiveXObject) {
    ajax = new ActiveXObject("Microsoft.XMLHTTP");
}

debugger
function addRemove(action) {
    var course = document.getElementById("class").innerHTML;

    if (action == "Add") {
        ajax.open("GET", "cart.aspx?action=" + action + "&class=" + encodeURIComponent(course) + "&value=" + Number(new Date), true);
    }
    else {
        ajax.open("GET", "cart.aspx?action=" + action + "&class=" + encodeURIComponent(course) + "&value=" + Number(new Date), true);
    }
    ajax.onreadystatechange = processCart;
    ajax.send(null);
}

debugger
function processCart()
{
    if (ajax.readyState == 4)
    {
        var xml = ajax.responseXML;
        var classes = xml.getElementsByTagName("class");
        //var classes = xml.getElementById("class");
        var output = document.getElementById("shopping");
        output.innerHTML = "";
        for (var i = 0; i < classes.length; i++)
        {
            if (window.ActiveXObject)
            {
                output.innerHTML += '<p>' + classes[0].firstChild.text;
                output.innerHTML += ' ' + classes[0].lastChild.text + ' ' + '<a href="javascript:addRemove(\'Remove\');">Remove Class</a></p>';
            }
            else
            {
                output.innerHTML += '<p>' + classes[0].firstChild.textContent;
                output.innerHTML += ' ' + classes[0].lastChild.textContent + ' ' + '<a href="javascript:addRemove(\'Remove\');">Remove Class</a></p>';
            }
        }
    }
}