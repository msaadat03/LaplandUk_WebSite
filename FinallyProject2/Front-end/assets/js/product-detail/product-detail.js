$(function () {
    $("#div3 img").mouseover(function () {
      document.getElementById("foto").src = this.src;
    });
  
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
  
    let products = [];
  
    if (localStorage.getItem("products") != null) {
      products = JSON.parse(localStorage.getItem("products"));
    }
  
    let heartCount = document.querySelector(".heart sup");
    let heartCount2 = document.querySelector("#scroll-section .heart sup");
  
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
  