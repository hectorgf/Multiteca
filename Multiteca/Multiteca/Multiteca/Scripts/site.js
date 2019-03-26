function InitializeCheckbox() {
	var checkboxContainerList = $('.input-checkbox-container');
	for (var i = 0; i < checkboxContainerList.length; i++) {
		if ($(checkboxContainerList[i]).contents('input').prop('checked') == false) {
			$(checkboxContainerList[i]).removeClass('active');
		}
		else {
			$(checkboxContainerList[i]).addClass('active');
		}
	}

	$('.input-checkbox-container').click(function () {
		if ($(this).hasClass('active')) {
			$(this).removeClass('active');
		}
		else {
			$(this).addClass('active');
		}

		$(this).contents('input:checkbox').prop('checked', !$(this).contents('input').prop('checked'));

		var objectId = '#' + $(this).contents('input:checkbox')[0].id;
		$(objectId).trigger("change");
	});
}

function InitializeImgFileupload() {
	$('.img-form-container img').click(function () {
		var objectId = '#' + $(this).parent().contents('input')[0].id;
		$(objectId).trigger("click");
	});

	$('.img-form-container input').change(function () {
		var input = this;
		var url = $(this).val();

		var imgId = $(this).parent().contents('img')[0].id;

		var fReader = new FileReader();
		fReader.readAsDataURL(input.files[0]);
		fReader.onloadend = function (event) {
			var img = document.getElementById(imgId);
			img.src = event.target.result;
		}
	});
}

$(document).ready(function () {
	//Inicializa los checkbox de la aplicación
	InitializeCheckbox();	

	//Inicializa los fileupload para imágenes
	InitializeImgFileupload();
});