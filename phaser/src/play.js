'use strict';

function Play(){
    this.level = null;
}

Play.prototype = {
    preload: function(){
        this.game.load.image('scientist_down', 'assets/Player_Scientist_01_Down.png');
        this.game.load.image('scientist_up', 'assets/Player_Scientist_01_Up.png');
        this.game.load.image('scientist_left', 'assets/Player_Scientist_01_Left.png');
        this.game.load.image('scientist_right', 'assets/Player_Scientist_01_Right.png')
    },
    create: function(){
        this.game.world.setBounds(0,0,1280,720);
        this.level = initLevel1(game);
    },
    update: function () {
        var keyboard = game.input.keyboard;
        for(var i=0; i < this.level.scientists.length; i++) {
            var scientist = this.level.scientists[i];
            if(scientist.isInfected) {
                moveScientist(keyboard, scientist);
            }
        }
    }
};

function moveScientist(keyboard, scientist) {
    var playerSpeed = 5;

    if (keyboard.isDown(Phaser.Keyboard.LEFT)||keyboard.isDown(Phaser.Keyboard.A))
    {
        scientist.movX(0 - playerSpeed);
        scientist.setDirection('left');
    }
    else if (keyboard.isDown(Phaser.Keyboard.RIGHT)||keyboard.isDown(Phaser.Keyboard.D))
    {
        scientist.movX(playerSpeed);
        scientist.setDirection('right');
    }
    else if (keyboard.isDown(Phaser.Keyboard.UP)||keyboard.isDown(Phaser.Keyboard.W))
    {
        scientist.movY(0 - playerSpeed);
        scientist.setDirection('up');
    }
    else if (keyboard.isDown(Phaser.Keyboard.DOWN)||keyboard.isDown(Phaser.Keyboard.S)) {
        scientist.movY(playerSpeed);
        scientist.setDirection('down');
    }
}

function initLevel1(game) {
    var level = {};
    level.scientists = [];
    level.scientists.push(createScientist(game, true, 100, 100));
    level.scientists.push(createScientist(game, true, 200, 200));
    level.scientists.push(createScientist(game, false, 300, 300));

    return level;
}

function createScientist(game, infected, posX, posY) {
    var scientist = {
        isInfected : infected,
        viewDirection: 'down',
        xPos: posX != null ? posX : 0,
        yPos : posY != null ? posY : 0,
        sprite : null,
        setPos : function (xPos, yPos) {
            scientist.xPos = xPos;
            scientist.yPos = yPos;
            scientist.sprite.x = xPos;
            scientist.sprite.y = yPos;
        },
        movX : function (val) {
            scientist.setPos(scientist.xPos + val, scientist.yPos);
        },
        movY : function (val) {
            scientist.setPos(scientist.xPos, scientist.yPos + val);
        },
        setDirection : function (direction) {
            switch (direction) {
                case 'down':
                    scientist.direction = direction;
                    scientist.sprite.loadTexture("scientist_down");
                    break;
                case 'up':
                    scientist.direction = direction;
                    scientist.sprite.loadTexture("scientist_up");
                    break;
                case 'left':
                    scientist.direction = direction;
                    scientist.sprite.loadTexture("scientist_left");
                    break;
                case 'right':
                    scientist.direction = direction;
                    scientist.sprite.loadTexture("scientist_right");
                    break;
            }
        }
    };
    scientist.sprite = game.add.sprite(scientist.xPos, scientist.yPos, "scientist_down");
    scientist.sprite.anchor.setTo(0.5, 0.5);
    return scientist;
}
