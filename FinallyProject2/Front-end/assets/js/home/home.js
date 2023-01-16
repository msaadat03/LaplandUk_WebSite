let items = document.querySelectorAll('.item')
let main = document.querySelector('.main')
let width = items[0].offsetWidth;
let count = 0;
let interval;
let btnPrev = document.querySelector('[data-btn-prev]')
let btnNext = document.querySelector('[data-btn-next]')


window.addEventListener('resize', function() {
  width = items[0].offsetWidth;

})

function getInterval() {
  return setInterval(() => {
    if (count === items.length - 1) {
      count = 0;
    } else {
      count++
    }
    MoveSlide(count)
  }, 2500)
}


interval = getInterval()


function MoveSlide(count) {
  main.style.translate = `${-100*count}% 0`
}


document.querySelectorAll('[data-slide-img]').forEach((img) => {
  img.addEventListener('mouseenter', function() {
    clearInterval(interval)
  })
  img.addEventListener('mouseleave', function() {
    interval = getInterval()
  })
})



btnNext.addEventListener('click', function() {
  if (count === items.length - 1) {
    count = 0;
  } else {
    count++
  }
  MoveSlide(count)
})


btnPrev.addEventListener('click', function() {
  if (count === 0) {
    count = items.length - 1
  } else {
    count--
  }
  MoveSlide(count)
})

const btns=[btnPrev,btnNext]
btns.forEach((btn) => {
  btn.addEventListener('mouseenter', function() {
    clearInterval(interval)
   
  })
  btn.addEventListener('mouseleave', function() {
    interval=getInterval()
   
  })
})
