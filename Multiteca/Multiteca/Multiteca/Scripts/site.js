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

$(document).ready(function () {
	//Inicializa los checkbox de la aplicación
	InitializeCheckbox();	
});