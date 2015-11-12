function hideHeader() {
    var elem = document.getElementById('headerLinks');
    elem.style.visibility = 'hidden';

    var elem1 = document.getElementById('homePageLink');
    elem1.removeAttribute('href');
}

$(document).ready(function () {

    var table = $('#myTable').DataTable({
        dom: 'Blfrtip',
        buttons: [
            'copy', 'csv', 'excel', 'pdf', 'print'
        ]
    });

    table.buttons().container()
        .appendTo($('.col-sm-6:eq(0)', table.table().container()));
  


    $('#myTable tbody').on('click', 'tr', function () {
        if ($(this).hasClass('selected')) {
            $(this).removeClass('selected');
        }
        else {
            table.$('tr.selected').removeClass('selected');
            $(this).addClass('selected');
        }
    });

    $('#button').click(function () {
        table.row('.selected').remove().draw(false);

    });

    $('#myTable tbody').on('click', 'tr', function () {
        var aData = table.row(this).data();
        window.location.replace("/Person/Agent?Id=" + aData[0]);     
    });

});