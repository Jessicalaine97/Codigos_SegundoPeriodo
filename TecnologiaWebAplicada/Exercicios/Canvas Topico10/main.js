import {Ball} from "./Ball.js";

const canvas = document.querySelector('canvas');
const ctx = canvas.getContext('2d');

const width = (canvas.width = window.innerWidth);
const height = (canvas.height = window.innerHeight);

// function to generate random number

function random(min, max) {
  const num = Math.floor(Math.random() * (max - min + 1)) + min;
  return num;
}

// function to generate random color

function randomRGB() {
  return `rgb(${random(0, 255)},${random(0, 255)},${random(0, 255)})`;
}

while (balls.length < 25) {
  let size = random(10,20);
  let ball = new Ball(
    random(0+size,width-size),
    random(0+size,height-size),
    random(-7,7),
    random(-7,7),
    randomRGB(),
    size
  );
  balls.push(ball);
}

let evil = new EvilCircle(random(0,width),random(0,height));
evil.setControls();

function loop() {

  ctx.fillStyle = 'rgba(0,0,0,1)';
  ctx.fillRect(0,0,width,height);

  balls.forEach( ball =>{
    if (ball.exists){
      ball.draw();
      ball.update();
      ball.collisionDetect();
    }
  });
  
  evil.draw();
  evil.checkBounds();
  evil.collisionDetect();

  requestAnimationFrame(loop);  
}

loop();





  





 
