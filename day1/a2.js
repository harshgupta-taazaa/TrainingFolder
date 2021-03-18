function nextCount() {
    let  c=0;
    function next() {
        c = c + 1;
        return c;
    }
 
    return next;
}
 
let ctr = nextCount();
console.log(ctr());
console.log(ctr());
console.log(ctr());
console.log(ctr());