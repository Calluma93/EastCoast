require('intersection-observer');
import './scss/index.scss';
import 'lightgallery';
import 'slick-carousel';
var $ = require("jquery");

//###### Lazy Load Images ######\\
function lazyLoading(){
	document.addEventListener("DOMContentLoaded", function() {

		var imageObserver = new IntersectionObserver(
			function(entries, observer) {
				var i;

				for( i = 0; i < entries.length; i++) {
					var entry = entries[i];
					if (entry.isIntersecting) {
						var image = entry.target;
						image.src = image.dataset.src;
						image.classList.remove("lazy");
						imageObserver.unobserve(image);
					}
				}
			},
			{
				rootMargin: "0px 0px 120px 0px"
			}
		);

		$('.lazy').each(function(i, element) {
			imageObserver.observe(element);
		});
	})
}

lazyLoading();

$(document).ready(function ($) {

    initialiseSliders() 

    $('.hamburger').click(function () {
        $('.menu').toggleClass('show');
    });

    $('.lightgallery').lightGallery({
        selector: '.item'
    });
    
    $.fn.random = function() {
        return this.eq(Math.floor(Math.random() * this.length));
    }          
      
    $('.product-banner').random().css("display", "block");
    
    $('.colour-option').click(function() {

        var largeImages = [];
        var smallImages = [];
        var largeGallery = [];
        var largeGalleryHref = [];
        var smallGallery = [];

        $(this).children(".large-images").each(function() { 
            largeImages.push($(this).data('src'));
        });

        $(this).children(".small-images").each(function() { 
            smallImages.push($(this).data('src'));
        });

        $('.large-gallery').each(function() { 
            largeGallery.push($(this));
        });

        $('.item').each(function() { 
            largeGalleryHref.push($(this));
        });

        $('.small-gallery').each(function() { 
            smallGallery.push($(this));
        });

        for(var i = 0; i < smallGallery.length; i++)
        {
            largeGallery[i].attr("src", largeImages[i]);
            largeGalleryHref[i].attr("href", largeImages[i]);
            smallGallery[i].attr("src", smallImages[i]);
        };
    });

    lazyLoading();

});

function initialiseSliders() {
    $('.banner-carousel').slick({
        slidesToShow: 1,
        slidesToScroll: 1,
        infinite: true,
        arrows: false,
        autoplay: true,
        autoplaySpeed: 5000,
        fade: true
    });
    
    $('.products-slider').slick({
        slidesToShow: 1,
        slidesToScroll: 1,
        arrows: false,
        fade: true,
        asNavFor: '.products-slider-nav'
    });
    
    $('.products-slider-nav').slick({
        arrows: false,
        slidesToShow: 9,
        slidesToScroll: 1,
        asNavFor: '.products-slider',
        dots: false,
        centerMode: false,
        focusOnSelect: true
    });
}