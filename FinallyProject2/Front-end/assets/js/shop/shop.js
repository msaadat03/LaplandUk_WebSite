"use strict";
$(function () {
  let scrollSection = document.getElementById("scroll-section");

  window.onscroll = function () {
    scrollFunction();
  };

  function scrollFunction() {
    if (
      document.body.scrollTop > 195 ||
      document.documentElement.scrollTop > 195
    ) {
      scrollSection.style.top = "0";
    } else {
      scrollSection.style.top = "-200px";
      $("div").removeClass("inActive");
    }
  }



  $(document).on('click', '.categories', function (e) {
    e.preventDefault();
    $(this).next().next().slideToggle();
  })

  $(document).on('click', '.category li a', function (e) {
    e.preventDefault();
    let category = $(this).attr('data-id');
    let products = $('.product-item');

    products.each(function () {
      if (category == $(this).attr('data-id')) {
        $(this).parent().fadeIn();
      }
      else {
        $(this).parent().hide();
      }
    })
    if (category == 'all') {
      products.parent().fadeIn();
    }
  })

  let addHeart = document.querySelectorAll("#shop-product #products .product-item .fa-heart");
  let heartCount = document.querySelector(".heart sup");
  let heartCount2 = document.querySelector("#scroll-section .heart sup");

  let products = [];

  if (localStorage.getItem("products") != null) {
    products = JSON.parse(localStorage.getItem("products"));
  }

  addHeart.forEach((heartBtn) => {
    heartBtn.addEventListener("click", function (e) {
      heartBtn.classList.toggle("my-active");

      e.preventDefault();

      let productImg =
        this.parentNode.parentNode.parentNode.firstElementChild.firstElementChild.getAttribute(
          "src"
        );
      let productName =
        this.parentNode.parentNode.parentNode.nextElementSibling.firstElementChild
          .innerText;
      let productPrice =
        this.parentNode.parentNode.parentNode.nextElementSibling.nextElementSibling.firstElementChild.innerText;
      let productId = parseInt(
        this.parentNode.parentNode.parentNode.parentNode.getAttribute("product-id")
      );

      let existProduct = products.find((m) => m.id == productId);

      if ((existProduct != undefined)) {
        existProduct.count += 0;
      } else {
        products.push({
          id: productId,
          image: productImg,
          name: productName,
          price: productPrice,
          count: 1,
        });
      }

      localStorage.setItem("products", JSON.stringify(products));

      heartCount.innerText = getHeartCount(products);
      heartCount2.innerText = getHeartCount(products);
    });
  });

  heartCount.innerText = getHeartCount(products);
  heartCount2.innerText = getHeartCount(products);

  function getHeartCount(heartCount) {
    let count = 0;
    for (const heart of heartCount) {
      count += heart.count;
    }
    return count;
  }
});

const rangeInput = document.querySelectorAll(".range-input input"),
  priceInput = document.querySelectorAll(".input-price input"),
  progress = document.querySelector(".range .progress");

let priceGap = 50;

priceInput.forEach((input) => {
  input.addEventListener("input", (e) => {
    let minVal = parseInt(priceInput[0].value),
      maxVal = parseInt(priceInput[1].value);

    if (maxVal - minVal >= priceGap && maxVal <= 631) {
      if (e.target.className === "input-min") {
        rangeInput[0].value = minVal;
        progress.style.left = (minVal / rangeInput[0].max) * 100 + "%";
      } else {
        rangeInput[1].value = maxVal;
        progress.style.right = 100 - (maxVal / rangeInput[1].max) * 100 + "%";
      }
    }
  });
});

rangeInput.forEach((input) => {
  input.addEventListener("input", (e) => {
    let minVal = parseInt(rangeInput[0].value),
      maxVal = parseInt(rangeInput[1].value);

    if (maxVal - minVal < priceGap) {
      if (e.target.className === "range-min") {
        rangeInput[0].value = maxVal - priceGap;
      } else {
        rangeInput[1].value = minVal + priceGap;
      }
    } else {
      priceInput[0].value = minVal;
      priceInput[1].value = maxVal;
      progress.style.left = (minVal / rangeInput[0].max) * 100 + "%";
      progress.style.right = 100 - (maxVal / rangeInput[1].max) * 100 + "%";
    }
  });
});
