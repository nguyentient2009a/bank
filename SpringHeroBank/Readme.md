- Ngân hàng số Spring Hero Bank cho phép người dùng thao tác những tác vụ sau.
  - Đăng ký tài khoản ngân hàng.
    - Mã hoá thông tin mật khẩu, tạo muối cho người dùng.
  - Đăng nhập vào hệ thống.
    - Kiểm tra password đã mã hoá.
  - Người dùng sau khi đăng nhập hệ thống có thể thực hiện các thao tác.
    - Gửi tiền vào tài khoản.
　　　- Rút tiền khỏi tài khoản (rút tiền tại ATM)
　　　- Mã giao dịch 
    - Chuyển tiền qua tài khoản người khác.
      - Check sự tồn tại của tài khoản nhận tiền và thông báo cho người dùng nếu không tồn tại.
      - Confirm số tiền và thông tin chuyển khoản.
    - Xem thông tin lịch sử giao dịch trong ngân hàng.
  - Tất cả các giao dịch đều phải lưu lịch sử giao dịch.
  
- Entity EntityModel EntityService EntityController View.
- Program.cs (Main) 
    -> View (Sinh ra menu cho người dùng) 
　　　-> Controller (Điều hướng, yêu cầu ng dùng 
　　　nhập thông tin cần thiết) 
    -> Service (Thực hiện các thao tác cần thiết trước khi làm việc với database,
        ví dụ cụ thể là mã hoá tài khoản, mã hoá mật khẩu trước khi đến hàm save trong model) 
    -> Model (Helper, Entity): CRUD với database.