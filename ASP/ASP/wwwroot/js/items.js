
//$(document).ready(function () {
//	$('[data-toggle="tooltip"]').tooltip();
//	var actions = $("table td:last-child").html();
//	// Append table with add row form on add new button click
//	$(".add-new").click(function () {
//		$(this).attr("disabled", "disabled");
//		var index = $("table tbody tr:last-child").index();
//		var row = '<tr>' +
//						'<td><input type="text" class="form-control" name="itemID" id="itemID"></td>' +
//						'<td><input type="text" class="form-control" name="itemName" id="itemName"></td>' +
//						'<td><input type="text" class="form-control" name="itemSize" id="itemSize"></td>' +
//						'<td><input type="text" class="form-control" name="itemPrice" id="itemPrice"></td>' +

//						'<td>' + actions + '</td>' +
//					'</tr>';
//		$("table").append(row);
//		$("table tbody tr").eq(index + 1).find(".add, .edit").toggle();
//		$('[data-toggle="tooltip"]').tooltip();
//	});
//	// Add row on add button click
//	$(document).on("click", ".add", function () {
//		var empty = false;
//		var input = $(this).parents("tr").find('input[type="text"]');
//		input.each(function () {
//			if (!$(this).val()) {
//				$(this).addClass("error");
//				empty = true;
//			} else {
//				$(this).removeClass("error");
//			}
//		});
//		$(this).parents("tr").find(".error").first().focus();
//		if (!empty) {
//			input.each(function () {
//				$(this).parent("td").html($(this).val());
//			});
//			$(this).parents("tr").find(".add, .edit").toggle();
//			$(".add-new").removeAttr("disabled");
//		}
//	});
//	// Edit row on edit button click
//	$(document).on("click", ".edit", function () {
//		$(this).parents("tr").find("td:not(:last-child)").each(function () {
//			$(this).html('<input type="text" class="form-control" value="' + $(this).text() + '">');
//		});
//		$(this).parents("tr").find(".add, .edit").toggle();
//		$(".add-new").attr("disabled", "disabled");
//	});
//	// Delete row on delete button click
//	$(document).on("click", ".delete", function () {
//		$(this).parents("tr").remove();
//		$(".add-new").removeAttr("disabled");
//	});
//});
function addRow(id, name, size, price) {
        $('[data-toggle="tooltip"]').tooltip();
	    var actions = $("table td:last-child").html();
		var index = $("table tbody tr:last-child").index();
    var row = `<tr id="${id}">` +
						`<td>${id}</td>` +
                        `<td>${name}</td>` +
                        `<td>${size}</td>` +
                        `<td>${price}</td>` +
                        '<td>'+
                            //'<a class="edit" title="Edit" data-toggle="tooltip"><i class="material-icons">&#xE254;</i></a>' +
                            `<a onclick="delClick(this)" data-del="${id}" class="delete" title="Delete" data-toggle="tooltip"><i class="material-icons">&#xE872;</i></a>` +
                        '</td>' +
					'</tr>';
        $("tbody").append(row);
	
}
function delClick(e)
{
    var id = e.getAttribute("data-del")
    var tr = $(`#${id}`) || null

//    console.log("ok");
    //var id = element.getAttribute("data-del");
    $.ajax({
        url: '/ControllerProduct/DeleteItem', // Đường dẫn đến phương thức SaveItem trong controller của bạn
        type: 'POST',
        data: {
            ID: id
        },
        success: function (response) {
            if (response.success) {
                tr.remove();
                alert('Xóa sản phẩm thành công!');
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
        var price = $('#price').val();

        $.ajax({
            url: '/ControllerProduct/SaveItem', // Đường dẫn đến phương thức SaveItem trong controller của bạn
            type: 'POST',
            data: {
                ID: id,
                Name: name,
                Size: size,
                Price: price
            },
            success: function (response) {
                if (response.success) {
                    $('#addProductModal').modal('hide');
                    addRow(id, name, size, price);
                    alert('Thêm sản phẩm thành công!');
                } else {
                    alert(response.message);
                }
            }
        });
    });

    



});

