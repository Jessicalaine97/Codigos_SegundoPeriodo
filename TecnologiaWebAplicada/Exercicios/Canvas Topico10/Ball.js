import {Shape} from "./Shape.js";
import {ctx, width, height, balls, randomRGB} from "./main.js";

function Ball(x,y,velX,velY,color,size) {
    Shape.call(this,x,y,velX,velY);
    this.color = color;
    this.size = size;  
  }

Ball.prototype = Object.create(Shape.prototype);
// Ball.protype.constructor = Ball;
Object.defineProperty(Ball.prototype, 'constructor',{
  value: Ball,
  enumerable: false,
  writable: true });


Ball.prototype.draw = function () {
  ctx.beginPath();
  ctx.fillStyle = this.color;
  ctx.arc(this.x,this.y,this.size,0,Math.PI * 2);
  ctx.fill();
}

Ball.prototype.update = function () {
  if ( (this.x+this.size) >= width ){
    this.velX = -(this.velX);
  }

  if ( (this.x+this.size) <= 0 ){
    this.velX = -(this.velX);
  }

  if ( (this.y+this.size) >= height ){
    this.velY = -(this.velY);
  }

  if ( (this.y+this.size) <= 0 ){
    this.velY = -(this.velY);
  }

  this.x += this.velX;
  this.y += this.velY;
}

Ball.prototype.collisionDetect = function () {
  balls.forEach((ball,j)=>{
    if(!(this == ball) && (ball.exists) && (this.exists)){
      const dx = this.x - ball.x;
      const dy = this.y - ball.y;
      const distance = Math.sqrt(dx*2+dy*2);
      if (distance < this.size+ball.size){
        this.color = ball.color = randomRGB();
        this.velX *= -1;
        this.velY *= -1;
        ball.velX *= -1;
        ball.velY *= -1;
      }
    }
  })
}


let balls = [];

