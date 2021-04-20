import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {MatSliderModule } from '@angular/material/slider';
import {MatButtonModule} from '@angular/material/button';
import {MatToolbarModule} from '@angular/material/toolbar';
import {MatInputModule} from '@angular/material/input';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { Button } from 'selenium-webdriver';
import { ProductComponent } from './product/product.component';
import { CategoryComponent } from './category/category.component';
import { AddproductComponent } from './addproduct/addproduct.component';
import { ShowProductComponent } from './show-product/show-product.component';
import { SearchProductComponent } from './search-product/search-product.component';
import { PricePipePipe } from './price-pipe.pipe';
import { ProductnamePipePipe } from './productname-pipe.pipe';
import { FormsModule } from '@angular/forms';
import { CategorySearchComponent } from './category-search/category-search.component';
import { CategoryPipePipe } from './category-pipe.pipe';
import { ListCategoriesComponent } from './list-categories/list-categories.component';
import { DeleteProductComponent } from './delete-product/delete-product.component';
import { DeleteCategoryComponent } from './delete-category/delete-category.component';

@NgModule({
  declarations: [
    AppComponent,
    ProductComponent,
    CategoryComponent,
    AddproductComponent,
    ShowProductComponent,
    SearchProductComponent,
    PricePipePipe,
    ProductnamePipePipe,
    CategorySearchComponent,
    CategoryPipePipe,
    ListCategoriesComponent,
    DeleteProductComponent,
    DeleteCategoryComponent,
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatSliderModule,
    MatButtonModule,
    MatToolbarModule,
    MatInputModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
