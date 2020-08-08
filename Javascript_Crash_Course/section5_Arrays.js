// Section 5 Arrays

let groceries = ['apples','bananas','carrots','dish soap','eggs',];

console.log(groceries);

groceries[3] = 'detergent';

console.log(groceries);

console.log(groceries.indexOf('detergent'));
console.log(groceries.includes('bananas'));

// Push and Pop: works the end

groceries.push('figs', 'greens',);
console.log('.push(args) = ', groceries);

groceries.pop();
console.log('.pop() = ', groceries);

// Shift and Unshift: works the beginning

console.log('groceries.shift() returns', groceries.shift());
console.log(groceries);

groceries.unshift('apples', 'apricots');
console.log('groceries.unshift(\'apples\', \'apricots\') returns ', groceries);

// Splice

groceries.splice(4, 0,'cauliflower');
console.log(groceries);

groceries.splice(5,2,'dish soap')
console.log(groceries)

/*  Exercise 11
Adam went to three different restaurants in the past week. The first restaurant gave him a bill of $88. The second restaurant gave him a bill of $42. The third restaurant gave him a bill of $104. 

Adam usually tips depending on the amount of the bill. If the bill is less than $50, he tips 25%. If the bill is between 50 and 100 inclusive, he tips 22.5%. Finally, if the bill is over $100, he tips 20%. 

1) Store the three bills in an array. 

2) Use the Tip Calculator from exercise 7 and amend it to reflect the different tipping conditions mentioned. 

3) Calculate the tips and store them in an array called tipAmounts.

4) Adam also wants to calculate the final amount that he has to pay including tips for each bill. Calculate the final amounts and store them in an array called totalAmounts. 
*/

let bills = [88,42,104]


function tipCalculator(cost){ //remeber D.R.Y.
    let tip;

        if(cost < 50){
            tip = cost * .25;
        }
        else if(cost >= 50 && cost <= 100){
            tip = cost * .225;
        }
        else {
            tip = cost * .2;
        }

    return tip
}

// using standard for loop

/*for(let bill = 0; bill < bills.length; bill++){
    console.log(tipCalculator(bills[bill]))
}
*/
// using forEach builtin function

let tipAmounts = []
let totalCosts = []

bills.forEach(function(bill){ 
    tipAmounts.push(tipCalculator(bill)); 
})

bills.forEach(function(bill){ 
        totalCosts.push(tipCalculator(bill) + bill); 
    })

console.log('Tip amouts are', tipAmounts.join(', '))
console.log('Total cost for each meal are', totalCosts.join(', '))