function animal(name,breed){
    this.name=name,
    this.breed=breed
}
function owner(owner){
    this.owner =owner
}

var p1= new animal("ghungroo","labra");
var p2=new owner("harsh");

p1.__proto__.owner=p2.owner;

console.log(p1.owner);

