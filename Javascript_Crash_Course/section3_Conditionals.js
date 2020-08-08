// Section 3

// Exercise 4

/*
Tom and Adam played 3 rounds of basketball against each other. Tom scored 51, 32 and 60 points, whereas Adam scored 44, 54 and 64 points. Calculate the average score of Tom and Adam and log to the console the winner. 

1) Store each score in a variable with a sensible name. 

2) Calculate the average of the three scores for each player and store the result in a variable.

3) Using an if... else statement or a switch statement, log to the console the winner based on the average scores. Remember, you need to account for a tie as well!
*/

let tomScores = [51, 32 , 60];
let adamScores = [44, 54, 64];
let scoreTotal = function(total, currentScore){return total + currentScore;};
let tomAverage = tomScores.reduce(scoreTotal) / tomScores.length;
let adamAverage = adamScores.reduce(scoreTotal) / adamScores.length;
let winner

if(tomAverage > adamAverage){
    winner = 'tom'
}else{winner = 'adam'}

switch (winner){

    case 'adam':
        console.log('Adam wins with a', Math.round(adamAverage), '!');
        break;

    case 'tom':
        console.log('Tom wins with a', Math.round(tomAverage),'!');
        break;
    
    default:
        console.log('It is a draw.')
}