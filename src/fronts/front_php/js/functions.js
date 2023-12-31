/* ==============================================
	Preload
=============================================== */
$(window).load(function() { // makes sure the whole site is loaded
	$('#status').fadeOut(); // will first fade out the loading animation
	$('#preloader').delay(250).fadeOut('slow'); // will fade out the white DIV that covers the website.
	$('body').delay(250).css({'overflow':'visible'});
	$('#sub_content').addClass('animated zoomIn');
	$(window).scroll();
	$('.number').each(function () {
    $(this).prop('Counter',0).animate({
        Counter: $(this).text()
    }, {
        duration: 2000,
        easing: 'swing',
        step: function (now) {
            $(this).text(Math.ceil(now));
        }
    });
});
})
/* ==============================================
	Sticky nav
=============================================== */
$(window).scroll(function(){
    'use strict';
    if ($(this).scrollTop() > 1){  
        $('header').addClass("sticky");
    }
    else{
        $('header').removeClass("sticky");
    }
});
/* ==============================================
	Common
=============================================== */
new WOW().init();

jQuery(function($) {
	"use strict";
	function centerModal() {
		$(this).css('display', 'block');
		var $dialog = $(this).find(".modal-dialog"),
			offset = ($(window).height() - $dialog.height()) / 2,
			bottomMargin = parseInt($dialog.css('marginBottom'), 10);
		if (offset < bottomMargin) offset = bottomMargin;
		$dialog.css("margin-top", offset);
	}
	$('.modal').on('show.bs.modal', centerModal);
	$('.modal-popup .close-link').click(function(event){
		event.preventDefault();
		$('.modal').modal('hide');
	});
	$(window).on("resize", function() {
		$('.modal:visible').each(centerModal);
	});
});

//Magnific popup -->	
$(function () {
'use strict';
$('.video_pop').magnificPopup({type:'iframe'});	/* video modal*/
/* Gallery images modal*/
$('.magnific-gallery').each(function() {
    $(this).magnificPopup({
        delegate: 'a', 
        type: 'image',
        gallery:{enabled:true},
		removalDelay: 500, //delay removal by X to allow out-animation
  callbacks: {
    beforeOpen: function() {
      // just a hack that adds mfp-anim class to markup 
       this.st.image.markup = this.st.image.markup.replace('mfp-figure', 'mfp-figure mfp-with-anim');
       this.st.mainClass = this.st.el.attr('data-effect');
    }
  },
  closeOnContentClick: true,
  midClick: true // allow opening popup on middle mouse click. Always set it to true if you don't provide alternative source.
    });
}); 
}); 

//Radio and checkbox styles -->	
$('input.icheck').iCheck({
   checkboxClass: 'icheckbox_square-grey',
   radioClass: 'iradio_square-grey'
 });
 
//Collapse filters close on mobile-->	
if( $(this).width() < 991 )
{
$('.collapse#collapseFilters').removeClass('in');
$('.collapse#collapseFilters').addClass('out');
}
else
{
$('.collapse#collapseFilters').removeClass('out');
$('.collapse#collapseFilters').addClass('in');
};

//Tooltip -->	
$('.tooltip-1').tooltip({html:true});

//Pace holder -->	
$('input, textarea').placeholder();

//Accordion -->	
function toggleChevron(e) {
    $(e.target)
        .prev('.panel-heading')
        .find("i.indicator")
        .toggleClass('icon_plus_alt2 icon_minus_alt2');
}
$('.panel-group').on('hidden.bs.collapse shown.bs.collapse', toggleChevron);

//Cat nav onclick active -->	
$('ul#cat_nav li a').on('click', function(){
    $('ul#cat_nav li a.active').removeClass('active');
    $(this).addClass('active');
});

//Drop down menu options-->	
$('.dropdown-menu').on("click",function(e) {e.stopPropagation();});  /* top drodown prevent close*/

function determineDropDirection(){
  $(".dropdown-menu").each( function(){
    // Invisibly expand the dropdown menu so its true height can be calculated
    $(this).css({
      visibility: "hidden",
      display: "block"
    });
    // Necessary to remove class each time so we don't unwantedly use dropup's offset top
    $(this).parent().removeClass("dropup");
    // Determine whether bottom of menu will be below window at current scroll position
    if ($(this).offset().top + $(this).outerHeight() > $(window).innerHeight() + $(window).scrollTop()){
      $(this).parent().addClass("dropup");
    }
    // Return dropdown menu to fully hidden state
    $(this).removeAttr("style");
  });
}
determineDropDirection();
$(window).scroll(determineDropDirection);

$("a.add_to_basket").on("click",function(){
$(".dropdown").removeClass("open");
});

/* ==============================================
	My Scripts
=============================================== */
$(document).ready(function() {
	var max_fields      = 10; //maximum input boxes allowed
	var wrapper   		= $(".input_fields_wrap"); //Fields wrapper
	var add_button      = $(".add_field_button"); //Add button ID
	
	var x = 1; //initlal text box count
	$(add_button).click(function(e){ //on add input button click
		e.preventDefault();
		if(x < max_fields){ //max input box allowed
			x++; //text box increment
			$(wrapper).append('<div><input type="text" name="mytext[]" placeholder="Dia de funcionamento" class="-function"/> <input type="time" name="mytext[]" placeholder="Horário de funcionamento"  class="-function"/> <a href="#" class="remove_field">Remover</a></div>'); //add input box
		}
	});
	
	$(wrapper).on("click",".remove_field", function(e){ //user click on remove text
		e.preventDefault(); $(this).parent('div').remove(); x--;
	})
});
  

$(document).ready(function () {
  var counter = 0;

  $("#addrow").on("click", function () {
      var newRow = $("<tr>");
      var cols = "";
      cols += '<td><input type="text" class="form-control" placeholder="+ R$3.50"/></td>';
      cols += '<td><input type="text" class="form-control" placeholder="Ex. Hambúrguer médio"/></td>';
      cols += '<td><input type="button" class="ibtnDel btn btn-md btn-danger "  value="Deletar"></td>';
      newRow.append(cols);
      $("table#order-item").append(newRow);
      counter++;
  });

  $("table#order-item").on("click", ".ibtnDel", function (event) {
      $(this).closest("tr").remove();       
      counter -= 1
  });
});

$(document).ready(function () {
  var counter = 0;

  $("#addkm").on("click", function () {
      var newRow = $("<tr>");
      var cols = "";
      cols += '<td><input type="text" class="form-control" placeholder="Valor"/></td>';
      cols += '<td><input type="text" class="form-control" placeholder="distancia inicial em KM"/></td>';
      cols += '<td><input type="text" class="form-control" placeholder="distancia final em KM"/></td>';
      cols += '<td><input type="button" class="ibtnDel btn btn-md btn-danger" value="Deletar"></td>';
      newRow.append(cols);
      $("table#order-km").append(newRow);
      counter++;
  });

  $("table#order-km").on("click", ".ibtnDel", function (event) {
      $(this).closest("tr").remove();       
      counter -= 1
  });
});

$(document).ready(function () {
  var counter = 0;

  $("#addrow-ingredientes").on("click", function () {
      var newRow = $("<tr>");
      var cols = "";
      cols += '<td><input type="text" class="form-control" placeholder="+ $3.50' + counter + '"/></td>';
      cols += '<td><input type="text" class="form-control" placeholder="Ex. Medium' + counter + '"/></td>';
      cols += '<td><input type="button" class="ibtnDel btn btn-md btn-danger "  value="Delete"></td>';
      newRow.append(cols);
      $("table.order-list-2").append(newRow);
      counter++;
  });

  $("table.order-list-2").on("click", ".ibtnDel", function (event) {
      $(this).closest("tr").remove();       
      counter -= 1
  });
});

/* $(document).ready(function () {
  var counter = 0;

  $("#addrow-perguntas").on("click", function () {
      var newRow = $("<tr>");
      var cols = "";
      cols += '<td><input type="text" class="form-control" placeholder="Pergunta"/></td>';
      cols += '<td><input type="button" class="ibtnDel btn btn-md btn-danger "  value="Delete"></td>';
      newRow.append(cols);
      $("table.order-list-3").append(newRow);
      counter++;
  });

  $("table.order-list-3").on("click", ".ibtnDel", function (event) {
      $(this).closest("tr").remove();       
      counter -= 1
  });
}); */

/* function calculateRow(row) {
  var price = +row.find('input[name^="price"]').val();
} */

/* function calculateGrandTotal() {
  var grandTotal = 0;
  $("table.order-list").find('input[name^="price"]').each(function () {
      grandTotal += +$(this).val();
  });
  $("#grandtotal").text(grandTotal.toFixed(2));
} */