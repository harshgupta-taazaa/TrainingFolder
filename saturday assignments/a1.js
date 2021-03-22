function animal(name,breed){
    this.name=name,
    this.breed=breed
}
function owner(owner){
    this.owner =owner
}

var p1= new animal("ghungroo","labra");
var p2=new owner("harsh");
animal.prototype.name=p1.name;
animal.prototype.breed=p1.breed;
owner.prototype.owner=p2.owner;
animal.appendPrototype = function(src) {
    for (var prop in src.prototype) {
        this.prototype[prop] = src.prototype[prop];
    }
}
animal.appendPrototype(owner);

console.log(p1.owner);
