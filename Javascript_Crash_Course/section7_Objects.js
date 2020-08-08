// Section 7 Objects

let car = {
    details: {
        make: 'Audi',
        model: 'A8',
        year: 2020,
        color: 'black',
    },
    'engine and transmission':{
        'fuel type': 'gasoline',
        engine: 'V8',
        transmission: 'manual',
    },
    safety:{
        locks:'child safety',
        brakes:'ABS'
    },
        message: function() {
        console.log('vroom vroom')
    }
}

console.log(car.make);
console.log(car['fuel type']);

car.engine = 'V8'

console.log(car)

delete car.model;

car.color = 'silver'

console.log(car)

car.message();

// Nested objects

console.log(car['engine and transmission'].engine)

// this keyword

let menu ={
    app: 'ceasar salad',
    main: 'steak',
    dessert: 'cheesecake',
    order: function(){
        console.log('I would like to start with', this.app, 'followed by a', this.main, 'and finally', this.dessert, 'please.')
    }
}

menu.order();

/*  Exercise 16
    create 2 objects
    create properties called scores
    create method that reurns average score
    log to console winnner based on average score
*/

let adam ={
    scores: [51,35,50],
    average: function(){
        let scoreTotal = 0;
        for(let score = 0; score < this.scores.length; score++){
            scoreTotal = scoreTotal + this.scores[score];
        }
        return Math.floor(scoreTotal / this.scores.length);
    }
}

let ben ={
    scores: [50,31,49],
    average: function(){
        let scoreTotal = 0;
        for(let score = 0; score < this.scores.length; score++){
            scoreTotal = scoreTotal + this.scores[score];
        }
        return Math.floor(scoreTotal / this.scores.length);
    }
}
 
if(ben.average() > adam.average()){
    console.log('Ben Wins');
}
else if(ben.average() < adam.average()){
    console.log('Adam Wins');
}
else{console.log('It\'s a draw.')}