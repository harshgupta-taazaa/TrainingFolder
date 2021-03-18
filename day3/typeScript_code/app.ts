// //import {Product} from "./product";
 
// // function getProduct(){
// //     let p=new Product();
// //     p.Id="1";
// //     p.price=100;
// //     p.title="Cricket bat";
// //     p.instock=true;
// //     return p;
// // }
 
// // let p=getProduct();
// // console.log(p);
 
// var isDone:boolean=false;
// var age:number=9;
// var abc:string="data coming from api";
// var list:Array<number>=[1,2,4];
// console.log(isDone);
// console.log(age);
// console.log(abc);
// console.log(list);
//arpitchangedsometimg
 
type Student={
    name:string,
    grade:number,
    age:number
}
type Player={
    name:string,
    sportsName:string
}
type Studentorplayer = Student | Player;
type Studentandplayer = Student & Player;
 
let myarr : Studentorplayer []=[{name:"neetika",grade:12,age:23},
{name:"arpit",grade:12,age:23},{name:"abc",grade:12,age:23}];
 
let yourarr :Studentandplayer[]=[{name:"acd",grade:12,age:23,sportsName:"cricket"},
{name:"ace",grade:12,age:23,sportsName:"cricket"}];
 
print7(myarr);
 
function print7(data: Studentorplayer[] | Studentandplayer[])
{
    data.forEach(d=>{
        console.log(d);
    })
}
 
// let list1:Array<Studentandplayer>=[]
// let list2:Array<string>=["neetika","cricket"];
 
 