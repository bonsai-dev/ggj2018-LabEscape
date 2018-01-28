'use strict';

function Menu(){
}

Menu.prototype = {
    preload: function(){
        this.game.stage.backgroundColor = "#FFFFFF";
        this.game.load.image('title', 'assets/title.png');
        this.game.load.image('scientist_down', 'assets/Player_Scientist_01_Down.png');

        this.game.load.spritesheet('start', 'assets/start.png', 263, 61);

    },

    create: function(){

        var title = this.game.add.sprite(500, 350, 'title');
        title.anchor.setTo(0.5, 0.5);
        title.scale.setTo(0.8, 0.8);

        game.add.tween(title.scale).to( { x: 0.95, y: 0.95}, 1300, Phaser.Easing.Quadratic.InOut, true, 0, 1000, true);

        var scientist = this.game.add.sprite(800, 600, 'scientist_down');
        scientist.anchor.setTo(0.5, 0.5);
        scientist.scale.setTo(3, 3);

        var startButton = this.game.add.button(150, 550, 'start', this.startGame, this, 1, 0);

        startButton.events.onInputOver.add(function(btn){
            btn.scale.x = 1.1;
            btn.scale.y = 1.1;

        }, this);

        startButton.events.onInputOut.add(function(btn){
            btn.scale.x = 1;
            btn.scale.y = 1;

        }, this);

    },

    update: function(){
    },

    startGame: function(){
        this.game.state.start('play');
    }
};