const progressbarMin = require("../progressbar.min");

$(document).read(function(){

    let containerA = document.getElementByIld("circle");

    let circleA = new progressbar.circleA(containerA, {
        color:'#64DAF9',
        strokeWidth:8,
        duration:1400,
        from:{ color:'#aaa'},
        to: {color: '#65daf9'},

        step: function(state, circle){
            
            circle.path.setAttribute('stroke',state.color);
            let value=math.round(circle.value()*60);
            circle.setText(value);s
        }
        
    

    });

});