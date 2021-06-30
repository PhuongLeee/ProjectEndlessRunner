# ProjectEndlessRunner

## Cài đặt
- Unity 2019.4.0
- FirebaseDatabase.unitypackage
- Các yêu cầu 1,2,3,4,5,7 được push ở nhánh main.
- Yêu cầu 6 được push ở nhánh Firebase và yêu cầu add thêm FirebaseDatabase.unitypackage và chuyển qua platform Android (Do thời gian có hạn em chưa thể push được phần này lên git hub ạ)
## Thời gian làm bài và đánh giá mức độ làm bài test.
Sau khi làm bài test trong 4 giờ, sau đây là thời gian em đã dành cho các task, và mức độ hoàn thành của bản thân:
- yêu cầu 1: (30 phút) đã hoàn thành.
- yêu cầu 2: (35 phút) đã hoàn thành.
- yêu cầu 3: (15 phút) đã hoàn thành tuy nhiên particle xấu và không được phù hợp với game.
- yêu cầu 4 và 5: (1 giờ) đã hoàn thành tuy nhiên nhân vật ở yêu cầu 5 do không đủ thời gian nên chưa thực sự tỉnh chỉnh được về phần màu sắc nhân vật.
- yêu cầu 6 : (1 giờ) đã hoàn thành.
- yêu cầu 7: (30 phút) đã hoàn thành.
## Ghi chú
- yêu cầu 2: để hiển thị popup như yêu cầu, em đã dùng cách sau: 
Người dùng thực hiện click lần lượt nửa trái màn hình sau đó đến phải... 
Sau khi click đủ 5 lần popup sẽ được hiển thị. Popup hỗ trợ cộng các thông số : fishBones, premium, item.
## Yêu cầu 7.
### Một số hướng cải thiện hiệu năng game em có thể đưa ra đó là:
- Tối ưu dung lượng, GPU, CPU:
	+ Nhực hiện resize ảnh phù hợp với kích thước cần dùng.
	+ Nén các texture hoặc giảm độ chi tiết của texture.
	+ Tối ưu lại UI, bỏ một số thuộc tính không cần thiết ví dụ như richtext, raycast target.
	+ Sử dụng occluding cho camera để giảm số lượng object phải render.
- Tối ưu bộ nhớ:
	+ Tối ưu lại code để tránh lãng phí bộ nhớ head và giảm lượng rác phải dọn bởi GC.
### Đánh giá tổ chức code.
Qua thời gian làm test em có nhận xét về tổ chức code trong game như sau:
Ưu điểm:
- Tổ chức thư mục: game được tổ chức theo em chưa được gọn gàng, tất cả các thư mục code, ảnh, plugin... đểu được để trong Asset. Điều này gây khó khăn trong quá trình đọc project và tìm kiếm trong code.
- Script có nhiều file quá dài về số dòng và số dòng trong hàm. Dẫn đến việc đọc hiểu project gặp khó khăn.
Nhược điểm:
- Trong project có sử dụng một số pattern như state pattern, Object pool, singleton... hỗ trợ cho hiệu xuất game.
### Em có một số đề xuất về cách tôt chức code như sau:
- Tổ chức thư mục:
	+ Các thư mục trong game nên được để chung vào một thư mục Game. Sau đó có thể chia ra thành các mục nhỏ hơn.
- Tổ chức code:
	+ Làm theo một số nguyên tắc tổ chức file code như :Các file code có thể chia nhỏ thành các file khác nhau, độ dài có thể dưới 200 dòng.
	+ Sử dụng một số pattern để tổ chức code.
## Lời cảm ơn
Em cảm ơn anh/chị và công ty đã dành thời gian cho CV cũng như tạo cơ hội làm bài test cho em. 
