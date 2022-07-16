## Tool cào dữ liệu từ trang web batdongsan.com.vn
Mục đích chính là cào toàn bộ các mục có trong menu, mỗi mục lấy các field tên, giá, diện tích, địa chỉ, ngày post bài, ưu tiên xem hay không,...
Kết quả sẽ được lưu vào các table trong cơ sở dữ liệu MySQL.
## Tool được viết bằng 
- Ngôn ngữ lập trình C#
- GUI dùng Winform Net 6.0
- Cơ sở dữ liệu MySQL
## NuGet packages
- Selenium.WebDriver
- Selenium.WebDriver.ChromeDriver
- Dapper
- MySQL.Data
### Danh sách cần crawl
![danh sách cần crawl](/Images/1.png)
### Ảnh test crawl data
![ảnh test crawl data](/Images/2.png)
### Dùng chế độ ẩn danh để loại bỏ capcha và dùng phiên bản chrome 102 để tránh lỗi selenium
![Dùng chế độ ẩn danh để loại bỏ capcha và dùng phiên bản chrome 102 để tránh lỗi selenium](/Images/7.png)
### Ảnh test lấy data đã lưu từ cơ sở dữ liệu
![ảnh test lấy data đã lưu từ cơ sở dữ liệu](/Images/3.png)
### Nhập file sql này vào trong MySQL workbench để có các bảng cơ sở dữ liệu bất động sản
![Nhập file sql này vào trong MySQL workbench để có các bảng cơ sở dữ liệu bất động sản](/Images/4.png)
### URL các danh mục, có 2 url, 1 là có phân trang và 2 là không phân trang
![URL các danh mục, có 2 url, 1 là có phân trang và 2 là không phân trang](/Images/5.png)
### Phiên bản Chrome 103.xxx bị lỗi tự động thoát Selenium, lỗi này vẫn chưa có cách khắc phục, dùng phiên bản Chrom 102 có thể tạm thời tránh được lỗi này
Tải bản 102 ở đường dẫn 
https://chromium.cypress.io/win64/stable/102.0.5005.63
![Phiên bản Chrome 103.xxx bị lỗi tự động thoát Selenium, lỗi này vẫn chưa có cách khắc phục, dùng phiên bản Chrom 102 có thể tạm thời tránh được lỗi này](/Images/6.png)
