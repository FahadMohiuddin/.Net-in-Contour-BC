function agechk(){
let a = document.getElementById("age");
let b = parseInt(a.value);

if ( b >= 18 && b <= 21){
    console.log("You'r allow to use mobile")
    document.getElementById("ans").innerHTML = "You'r allow to use mobile";
}
else if( b > 21){
    document.getElementById("ans").innerHTML = "You'r allow to use Laptop";
}
else{
    document.getElementById("ans").innerHTML = "Invalid";
}
}