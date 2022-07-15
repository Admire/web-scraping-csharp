## Tool cào dữ liệu từ trang web batdongsan.com.vn
Mục đích chính là cào toàn bộ các mục có trong menu, mỗi mục lấy các field tên, giá, diện tích, địa chỉ, ngày post bài, ưu tiên xem hay không,...
Kết quả sẽ được lưu vào các table trong cơ sở dữ liệu MySQL.
### Danh sách cần crawl
![danh sách cần crawl](/Screenshots/1.png)
### Ảnh test crawl data
![ảnh test crawl data](/Screenshots/2.png)
### Ảnh test lấy data đã lưu từ cơ sở dữ liệu
![ảnh test lấy data đã lưu từ cơ sở dữ liệu](/Screenshots/3.png)
### Nhập file sql này vào trong MySQL workbench để có các bảng cơ sở dữ liệu bất động sản
![Nhập file sql này vào trong MySQL workbench để có các bảng cơ sở dữ liệu bất động sản](/Screenshots/4.png)
## Tool được viết bằng 
- Ngôn ngữ lập trình C#
- GUI dùng Winform Net 6.0
- Cơ sở dữ liệu MySQL
## NuGet packages
- Selenium.WebDriver
- Selenium.WebDriver.ChromeDriver
- Dapper
- MySQL.Data