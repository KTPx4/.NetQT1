
function addRow(id, name, size) {
    $('[data-toggle="tooltip"]').tooltip();
    var actions = $("table td:last-child").html();
    var index = $("table tbody tr:last-child").index();
    var row = `<tr id="${id}">` +
        `<td>${id}</td>` +
        `<td>${name}</td>` +
        `<td>${size}</td>` +
      
        '<td>' +
        //'<a class="edit" title="Edit" data-toggle="tooltip"><i class="material-icons">&#xE254;</i></a>' +
        `<a onclick="delClick(this)" data-del="${id}" class="delete" title="Delete" data-toggle="tooltip"><i class="btn btn-danger">Delete</i></a>` +
        '</td>' +
        '</tr>';
    $("tbody").append(row);

}
function delClick(e) {
    var id = e.getAttribute("data-del")
    var tr = $(`#${id}`) || null

    //    console.log("ok");
    //var id = element.getAttribute("data-del");
    $.ajax({
        url: '/ControllerCustomer/Delete', // Đường dẫn đến phương thức SaveItem trong controller của bạn
        type: 'POST',
        data: {
            ID: id
        },
        success: function (response) {
            if (response.success) {
                tr.remove();
                alert(response.message);
            } else {
                alert(response.message);
            }
        }
    });

};
$(document).ready(function () {
    $('#addProduct').click(function () {
        $('#addProductModal').modal('show');
    });
    $('#closeModel').click(() => {
        $('#addProductModal').modal('hide');
    })
    $('#saveProduct').click(function () {
        var id = $('#id').val();
        var name = $('#name').val();
        var size = $('#size').val();
       

        $.ajax({
            url: '/ControllerCustomer/Save', // Đường dẫn đến phương thức SaveItem trong controller của bạn
            type: 'POST',
            data: {
                ID: id,
                Name: name,
                Address: size              
            },
            success: function (response) {
                if (response.success) {
                    $('#addProductModal').modal('hide');
                    addRow(id, name, size);
                    alert(response.message);
                } else {
                    alert(response.message);
                }
            }
        });
    });





});

