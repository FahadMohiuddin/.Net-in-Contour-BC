function chk(){

    let a = document.getElementById("inp");
    let b = parseInt(a.value);
    let ans = document.getElementById("ans");

    if(b % 2 == 0){
        ans.innerHTML = "Even number";
    }
    else{
        ans.innerHTML = "Odd number";
    }
}