function solve(input){
    let days = 0;
    let yield = 0;

    while(input >= 100){ //at least 100 is the source
        days = days + 1;
        yield = yield + input - 26;
        input = input - 10;
    }

    if(yield >= 10){// at least our yield is 10
        yield = yield - 26;
    }
    else{
        yield = 0;
    }
    console.log(`${days}\n${yield}`);    
}