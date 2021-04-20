import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddproductComponent } from './addproduct/addproduct.component';
import { CategorySearchComponent } from './category-search/category-search.component';
import { CategoryComponent } from './category/category.component';
import { DeleteCategoryComponent } from './delete-category/delete-category.component';
import { DeleteProductComponent } from './delete-product/delete-product.component';
import { ListCategoriesComponent } from './list-categories/list-categories.component';
import { ProductComponent } from './product/product.component';
import { SearchProductComponent } from './search-product/search-product.component';
import { ShowProductComponent } from './show-product/show-product.component';

const routes: Routes = [
  {path:"",redirectTo:"home",pathMatch:"full"},
    {path:"product",component:ProductComponent,
  children:[ {path:"addproduct",component:AddproductComponent},
  {path:"showproduct",component:ShowProductComponent},
  {path:"searchproduct",component:SearchProductComponent},
  {path:"deleteproduct",component:DeleteProductComponent}]
  },
    {path:"category",component:CategoryComponent,
  children:[{path:"categorySearch",component:CategorySearchComponent},
  {path:"Categories",component:ListCategoriesComponent},
  {path:"addproduct",component:AddproductComponent},
  {path:"deletecategory",component:DeleteCategoryComponent}
]
  },
    {path:"addproduct",component:AddproductComponent},
    {path:"showproduct",component:ShowProductComponent},
    {path:"searchproduct",component:SearchProductComponent},
    {path:"categorySearch",component:CategorySearchComponent},
    {path:"Categories",component:ListCategoriesComponent},
    {path:"deleteproduct",component:DeleteProductComponent},
    {path:"deletecategory",component:DeleteCategoryComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
