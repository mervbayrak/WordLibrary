# WordLibrary

<table>
<tr>
<td>
  <b>Packages-technologies used</b>

* [**Microsoft.EntityFrameworkCore / Version 5.0.1**](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore) 
* [**FluentValidation / Version 9.3.0**](https://www.nuget.org/packages/FluentValidation/) 
* [**AutoMapper / Version 10.1.1**](https://www.nuget.org/packages/AutoMapper/) 
* [**PostSharp / Version 6.8.7**](https://www.nuget.org/packages/PostSharp/) 


</td>
</tr>
</table>


### [About Layered](#About-Layered)
<table>
  <tr>
<td>
  
#### [Core Layer](https://github.com/mervbayrak/WordLibrary/tree/master/WordLibrary.Core) : 
* Bu katman projede bir kez kullanılacak, ortak sınıfların, methodların olduğu kısımdır. 

<table>
<tr>
<td>PackageReference</td>
<td>Projects</td>
</tr>
<tr>
<td>

* AutoMapper
* FluentValidation
* Microsoft.EntityFrameworkCore
* Microsoft.EntityFrameworkCore.SqlServer
* PostSharp
      
</td>
<td></td>
</tr>
</table>
 


#### [Data Access Layer](https://github.com/mervbayrak/WordLibrary/tree/master/WordLibrary.DataAccess) : 
* Bu katmanda sadece veritabanı işlemleri yapılmaktadır. Bu katmanın görevi veriyi ekleme, silme, güncelleme ve veritabanından çekme işlemidir. 

<table>
<tr>
<td>PackageReference</td>
<td>Projects</td>
</tr>
<tr>
<td>
  
* Microsoft.EntityFrameworkCore
* Microsoft.EntityFrameworkCore.SqlServer
</td>
<td>
  
* Core
* Entity
</td>
</tr>
</table>



#### [Entity Layer](https://github.com/mervbayrak/WordLibrary/tree/master/WordLibrary.Entities) : 
* Bu katmanda veriler için hazırlanan class larımızı tutuyoruz.
<table>
<tr>
    <td>PackageReference</td>
    <td>Projects</td>
</tr>
<tr>
<td>
  </td>
<td>
  
 * Core
  </td>
</tr>
</table>

#### [Business Layer](https://github.com/mervbayrak/WordLibrary/tree/master/WordLibrary.Business) : 
* Bu katmanda iş yüklerimizi yazıyoruz. Öncelikle şunu söylemeliyim bu katman Data Access tarafından projeye çekilmiş olan verileri alarak işleyecek olan katmandır. 
<table>
<tr>
    <td>PackageReference</td>
    <td>Projects</td>
</tr>
<tr>
<td>
  
* AutoMapper
* FluentValidation

</td>
<td>

* Core
* Data Access
* Entity
  </td>
</tr>
</table> 


#### [UI Layer](https://github.com/mervbayrak/WordLibrary/tree/master/WordLibrary.API) :
* Bu proje için ayrı bi web sitesi farklı repo da paylaşılacaktır. 
<table>
<tr>
    <td>PackageReference</td>
    <td>Projects</td>
</tr>
<tr>
<td>
      
* AutoMapper
* AutoMapper.Extensions.Microsoft.DependencyInjection
* Microsoft.EntityFrameworkCore
* Microsoft.EntityFrameworkCore.SqlServer
</td>
<td>
  
* Business
* Entity
  </td>
</tr>
</table> 

</td>
</tr>
</table>



