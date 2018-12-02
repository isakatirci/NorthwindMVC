
var uri = 'api/products';

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



function geteditdetails(id) {
    // Send an AJAX request
    $.getJSON(window.getBaseUrl() + uri + "/" + id)
        .done(function(data) {
            // On success, 'data' contains an item mytestclass1.
            $("#hiddenid").val(0);
            for (var i = 0; i < colnames.length; i++)
                $("#" + colnames[i]).val(data[colnames[i]]);
    });
}

function updateitem() {
    $.ajax({
        type: 'Put',
        url: window.getBaseUrl() + uri + "/" + $('#İd').val(),
        data: getformvalues(),
        dataType: "json"
    })
   .done(function ()
        {
            clearlist();
            getlist(0);
            $("#list").show();
            $("#edit").hide();
        })
   .error(function () { alert("error updating item"); });
}

function addnewitem() {
    $.ajax({
        type: 'Post',
        url: window.getBaseUrl() + uri,
        data: getformvalues(),
        dataType: "json"
    })
    .done(function ()
        {
            clearlist();
            getlist(0);
            $("#list").show();
            $("#edit").hide();
        })
    .error(function () { alert("error adding item"); });
}

function deleteitem(id)
{
    $.ajax({
            type: 'Delete',
            url: window.getBaseUrl() + uri + '?id=' + id
        })
        .done(function() 
        { 
            clearlist(); 
            getlist(0); 
        });
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
    row += "<td><a href='#' onclick='showedit(\"" + item.İd + "\", false)'>edit</a>";
    row += "&nbsp;<a href='#' onclick='confirmdelete(\"" + item.İd + "\")'>delete</a></td>";
    row += "</tr>";
    return row;
}


function showedit(id, isnew) {
    $("#list").hide();
    $("#edit").show();
    clearedit();

    if (isnew)
    {
        $("#İd").removeAttr('readonly');
        $("#formcaption").html("Add new item");
        $("#hiddenid").val(-1);
        $("#updatebtn").html("Add");
    }
    else {
        $("#İd").attr('readonly');
        $("#formcaption").html("Edit item");
        $("#updatebtn").html("Update");
        geteditdetails(id);
    }
}

function canceledit()
{
    $("#list").show();
    $("#edit").hide();
}

function clearedit()
{
    $("#hiddenid").val(-1);
    for (var i = 0; i < colnames.length; i++)
        $("#" + colnames[i]).val("");
}

function update()
{
    if ($("#hiddenid").val() === "-1")
        addnewitem();
    else
        updateitem();
}

function confirmdelete(id)
{
    if (confirm("Are you sure you want to delete this item?"))
        deleteitem(id);
}

function getformvalues()
{
    var data = {};
    $("#editDetailForm").serializeArray().map(function(x) { data[x.name] = x.value; });
    return JSON.parse(JSON.stringify(data));
}


var colnames = [
	 "Supplierİds"
	, "İd"
	, "ProductCode"
	, "ProductName"
	, "Description"
	, "StandardCost"
	, "ListPrice"
	, "ReorderLevel"
	, "TargetLevel"
	, "QuantityPerUnit"
	, "Discontinued"
	, "MinimumReorderQuantity"
	, "Category"
	, "Attachments"
];
