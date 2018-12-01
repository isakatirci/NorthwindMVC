
var uri = 'api/salesbycategory';

$(document).ready(function() {
    $("#edit").hide();
    getlist(0);
});

function getlist(page)
{
    // Send an AJAX request
    $.getJSON(getBaseUrl() + uri + "/?page=" + page)
        .done(function(data) {
            // On success, 'data' contains a list of mytestclass1.
            $.each(data.Data, function(key, item) {
                // Add a list item for the product.
                $('#listbody').html($('#listbody').html() + formatItem(item));
            });

            $(".pagination").html("");
            var style = 'normal';
            var numSteps = 5;
            var startPos = (data.Paging.CurrentPage - numSteps < 0 ? 0 : data.Paging.CurrentPage - numSteps);
            var endPos = (data.Paging.CurrentPage + numSteps > (data.Paging.PageCount) ? data.Paging.PageCount : data.Paging.CurrentPage + numSteps);
            if (startPos !== 0) $(".pagination").html(getpagelink(0, "&lt;&lt;", style));

            for (var i = startPos; i < endPos; i++)
            {
                var pageNum = i + 1;
                if (i === data.Paging.CurrentPage) style = 'active'; else style = 'normal';
                $(".pagination").html($(".pagination").html() + getpagelink(i, pageNum, style));
            }
            if (endPos !== data.Paging.PageCount) $(".pagination").html($(".pagination").html() + getpagelink(data.Paging.PageCount - 1, "&gt;&gt;", 'normal'));

        });
}

function getpagelink(i, txt, style)
{
    return "<li " + (style==='active' ? "class='active'" : "") + "><a href = '#' onclick='clearlist(); getlist(" + i + ")'>" + txt + "</a></li>";
}



function clearlist()
{
    $('#listbody').html("");
}

function formatItem(item) {
    var row = "<tr>";
    for (var i = 0; i < colnames.length; i++)
    {
        row += "<td>" + item[colnames[i]] + "</td>";
    }
    row += "<td></td>";
    row += "</tr>";
    return row;
}

var colnames = [
	 "CategoryID"
	, "CategoryName"
	, "ProductName"
	, "ProductSales"
];
