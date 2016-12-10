SELECT SOHDN
FROM HDN
ORDER BY SOHDN
set dateformat dmy

SELECT SOHDX
FROM HDX
ORDER BY SOHDX
set dateformat dmy

SELECT MAX(NGAYN)'NGÀY NHẬP HÀNG GẦN NHẤT'
FROM HDN
WHERE NGAYN > '2016-05-15'
GROUP BY NGAYN
set dateformat dmy

SELECT TENNV,USERID
FROM NV
WHERE ACTIVE='1'
ORDER BY USERID ASC;





