import {Shape} from "./Shape.js";

export function EvilCircle(x,y){
    Shape.call(this,x,y,20,20);
    this.color = 'white';
    this.size = 10;
  }
  
  EvilCircle.prototype = Object.create(Shape.prototype);
  Object.defineProperty(EvilCircle.prototype, 'constructor',{
    value: EvilCircle,
    enumerable: false,
    writable: true });
  
  
  EvilCircle.prototype.draw = function(){
    ctx.beginPath();
    ctx.strokeStyle = this.color;
    ctx.lineWidth = 3;
    ctx.arc(this.x,this.y,this.size,0,Math.PI * 2);
    ctx.stroke();
  }
  
  EvilCircle.prototype.checkBounds = function (){
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
  }
  
  EvilCircle.prototype.setControls = function (){
  
    var _this = this;
  
    window.onkeydown = function(event){
      if (event.key === 'a'){
        _this.x -= _this.velX;
      } else if (event.key === 'd'){
        _this.x += _this.velX;
      } else if (event.key === 'w'){
        _this.y -= _this.velY;
      } else if (event.key === 's'){
        _this.y += _this.velY;
      }
    }
  }
  
  EvilCircle.prototype.collisionDetect = function () {
  
    balls.forEach((ball)=>{
      if (ball.exists){
        const dx = this.x - ball.x;
        const dy = this.y - ball.y;
        const distance = Math.sqrt(dx*2+dy*2);
        if (distance < this.size+ball.size){
          ball.exists = false;
        }
      }
    });
  }