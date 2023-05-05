import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PracticeWithJsonDataComponent } from './practice-with-json-data/practice-with-json-data.component';

const routes: Routes = [{ path: '', component: PracticeWithJsonDataComponent }];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
