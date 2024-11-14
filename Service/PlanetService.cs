using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspMVCEcomerce.Models;

namespace AspMVCEcomerce.Service
{
    public class PlanetService : List<PlanetModel>
    {   
        public PlanetService(){
            this.AddRange(
                new PlanetModel[]{
                new PlanetModel(){
                    Id = 1,
                    Name = "Mercury",
                    VnName = "Sao Thủy",
                    Content = @"Sao Thủy (tiếng Anh: Mercury) hay Thủy Tinh (chữ Hán: 水星) là hành tinh nhỏ nhất và gần Mặt Trời 
                    nhất trong tám hành tinh thuộc hệ Mặt Trời, với chu kỳ quỹ đạo bằng khoảng 88 ngày Trái Đất. Nhìn từ Trái Đất, 
                    hành tinh hiện lên với chu kỳ giao hội trên quỹ đạo bằng xấp xỉ 116 ngày, và nhanh hơn hẳn những hành tinh khác. 
                    Tốc độ chuyển động nhanh này đã khiến người La Mã đặt tên hành tinh là Mercurius, vị thần liên lạc và đưa tin một cách nhanh chóng. 
                    Trong thần thoại Hy Lạp tên của vị thần này là Hermes (Ερμής). Tên tiếng Việt của hành tinh này dựa theo tên do Trung Quốc đặt, 
                    chọn theo hành thủy trong ngũ hành."
                },
                new PlanetModel(){
                    Id = 2,
                    Name = "Venus",
                    VnName = "Sao Kim",
                    Content = @"Sao Kim hay Kim Tinh (chữ Hán: 金星), còn gọi là sao Thái Bạch (太白), Thái Bạch Kim Tinh (太白金星) (tiếng Anh: Venus) 
                    là hành tinh thứ 2 trong Hệ Mặt Trời, tự quay quanh nó với chu kỳ khoảng 243 ngày Trái Đất. Xếp sau Mặt Trăng, nó là thiên thể 
                    tự nhiên sáng nhất trong bầu trời tối, với cấp sao biểu kiến bằng −4.6, đủ sáng để tạo nên bóng trên mặt nước. Bởi vì Sao Kim 
                    là hành tinh phía trong tính từ Trái Đất, nó không bao giờ xuất hiện trên bầu trời mà quá xa Mặt Trời: góc ly giác đạt cực đại bằng 47,8°.
                     Sao Kim đạt độ sáng lớn nhất ngay sát thời điểm hoàng hôn hoặc bình minh, do vậy mà dân gian còn gọi là sao Hôm, khi hành tinh này hiện 
                     lên lúc hoàng hôn, và sao Mai, khi hành tinh này hiện lên lúc bình minh."
                },
                new PlanetModel(){
                    Id = 3,
                    Name = "Earth",
                    VnName = "Trái Đất",
                    Content = @"Trái Đất, hay còn gọi là Địa Cầu (chữ Hán: 地球 hoặc Quả Đất, hành tinh xanh, hành tinh, quả bóng xanh, tiếng Anh: Earth), 
                    là hành tinh thứ ba tính từ Mặt Trời, đồng thời cũng là hành tinh lớn nhất trong các hành tinh đất đá của hệ Mặt Trời xét về bán kính, 
                    khối lượng và mật độ của vật chất. Trái Đất còn được biết tên với các tên gọi 'hành tinh xanh', là nhà của hàng triệu loài sinh 
                    vật, trong đó có con người và cho đến nay nó là nơi duy nhất trong vũ trụ được biết đến là có sự sống. Hành tinh này được hình thành cách đây khoảng 
                    4,55 tỷ năm và sự sống xuất hiện trên bề mặt của nó khoảng 1 tỷ năm trước. Kể từ đó, sinh quyển, khí quyển của Trái Đất và các điều kiện vô cơ khác đã 
                    thay đổi đáng kể, tạo điều kiện thuận lợi cho sự phổ biến của các vi sinh vật ưa khí cũng như sự hình thành của tầng ôzôn-lớp bảo vệ quan trọng, cùng 
                    với từ trường của Trái Đất, đã ngăn chặn các bức xạ có hại và chở che cho sự sống. Các đặc điểm vật lý của Trái Đất cũng như lịch sử địa lý hay quỹ đạo, 
                    cho phép sự sống tồn tại trong thời gian qua. Người ta ước tính rằng Trái Đất chỉ còn có thể hỗ trợ sự sống thêm 1,5 tỷ năm nữa, trước khi kích thước của 
                    Mặt Trời tăng lên (trở thành sao khổng lồ đỏ) và tiêu diệt hết sự sống."
                },
                new PlanetModel(){
                    Id = 4,
                    Name = "Mars",
                    VnName = "Sao Hỏa",
                    Content = @"Sao Hỏa (tiếng Anh: Mars) hay Hỏa Tinh (chữ Hán: 火星) là hành tinh thứ tư ở Hệ Mặt Trời và là hành tinh đất đá ở xa Mặt Trời nhất,
                     với bán kính bé thứ hai so với các hành tinh khác. Sao Hoả có màu cam đỏ do bề mặt của hành tinh được bao phủ bởi lớp vụn sắt(III) oxit, do đó còn có tên gọi 
                     khác là 'hành tinh đỏ'. Vì bán cầu Bắc của Sao Hoả có bồn trũng Bắc Cực chiếm đến 40% diện tích hành tinh, 
                     so bán cầu Nam thì bán cầu Bắc phẳng hơn và ít hố va chạm hơn. Khí quyển của Sao Hoả khá mỏng với thành phần chính là cacbon dioxit.
                      Ở hai cực Sao Hoả là lớp băng được làm bằng nước. Sao Hoả có hai vệ tinh tự nhiên: Phobos và Deimos."
                },
                new PlanetModel(){
                    Id = 5,
                    Name = "Jupiter",
                    VnName = "Sao Mộc",
                    Content = @"Sao Mộc (tiếng Anh: Jupiter) hay Mộc Tinh (chữ Hán: 木星) là hành tinh thứ năm tính từ Mặt Trời và là hành tinh lớn nhất trong Hệ Mặt Trời.
                     Nó là hành tinh khí khổng lồ với khối lượng bằng một phần nghìn của Mặt Trời nhưng bằng hai lần rưỡi tổng khối lượng của tất cả các hành tinh khác 
                     trong Hệ Mặt Trời cộng lại. Sao Mộc được xếp vào nhóm hành tinh khí khổng lồ cùng với Sao Thổ (Sao Thiên Vương và Sao Hải Vương được xếp vào hành 
                     tinh băng khổng lồ). Hai hành tinh này đôi khi được gọi là hành tinh kiểu Sao Mộc hoặc hành tinh vòng ngoài. Các nhà thiên văn học cổ đại đã biết đến hành tinh này, 
                     và gắn với thần thoại và niềm tin tôn giáo trong nhiều nền văn hóa. Người La Mã đặt tên hành tinh theo tên của vị thần Jupiter, vị thần quan trọng nhất trong số 
                     các vị thần. Tên gọi trong tiếng Trung Quốc, tiếng Triều Tiên, tiếng Nhật và tiếng Việt của hành tinh này được đặt dựa vào hành 'mộc' trong ngũ hành. Khi nhìn từ 
                     Trái Đất, Sao Mộc có cấp sao biểu kiến −2,94, đủ sáng để tạo bóng; và là thiên thể sáng thứ ba trên bầu trời đêm sau Mặt Trăng và Sao Kim. (Sao Hỏa hầu như sáng 
                     bằng Sao Mộc khi Sao Hỏa ở những vị trí xung đối trên quỹ đạo của nó với Trái Đất)."
                },
                new PlanetModel(){
                    Id = 6,
                    Name = "Saturn",
                    VnName = "Sao Thổ",
                    Content = @"Sao Thổ (tiếng Anh: Saturn), hay Thổ Tinh (土星) là hành tinh thứ sáu tính theo khoảng cách trung bình từ Mặt Trời và là hành tinh lớn
                     thứ hai về đường kính cũng như khối lượng, sau Sao Mộc trong hệ Mặt Trời. Tên tiếng Anh của hành tinh mang tên thần Saturn trong thần thoại La Mã, 
                     ký hiệu thiên văn của hành tinh là (♄) thể hiện cái liềm của thần. Sao Thổ là hành tinh khí khổng lồ với bán kính trung bình bằng 9 lần của Trái Đất.
                      Tuy khối lượng của hành tinh cao gấp 95 lần khối lượng của Trái Đất nhưng với thể tích lớn hơn 763 lần, khối lượng riêng trung bình của Sao Thổ chỉ 
                      bằng một phần tám so với của Trái Đất."
                },
                new PlanetModel(){
                    Id = 7,
                    Name = "Uranus",
                    VnName = "Sao Thiên Vương",
                    Content = @"Sao Thiên Vương (tiếng Anh: Uranus) hay Thiên Vương Tinh (chữ Hán: 天王星) là hành tinh thứ bảy tính từ Mặt Trời, là hành tinh có bán kính 
                    lớn thứ ba và có khối lượng lớn thứ tư trong Hệ Mặt Trời. Sao Thiên Vương có thành phần tương tự như Sao Hải Vương. Cả hai có thành phần hóa học khác
                     so với hai hành tinh khí khổng lồ lớn hơn là Sao Mộc và Sao Thổ. Vì vậy, các nhà thiên văn thỉnh thoảng đưa các hành tinh này vào danh sách 'hành tinh băng khổng lồ'. 
                     Khí quyển của Sao Thiên Vương tương tự như của Sao Mộc và Sao Thổ về thành phần cơ bản như hiđrô và heli. Khác là chúng chứa nhiều hợp chất dễ bay hơi như nước, 
                     amonia và methan cùng với lượng nhỏ hydrocarbon. Hành tinh này có bầu khí quyển lạnh nhất trong số các hành tinh trong Hệ Mặt Trời, với nhiệt độ cực tiểu bằng 49 K 
                     (−224 °C). Nó có cấu trúc tầng mây phức tạp. Khả năng những đám mây thấp nhất chứa chủ yếu nước trong khi methan lại chiếm chủ yếu trong những tầng mây phía trên. 
                     Ngược lại, cấu trúc bên trong Sao Thiên Vương chỉ chứa chủ yếu một lõi băng và đá."
                },
                new PlanetModel(){
                    Id = 8,
                    Name = "Neptune",
                    VnName = "Sao Hải Vương",
                    Content = @"Sao Hải Vương (tiếng Anh: Neptune), hay Hải Vương Tinh (chữ Hán: 海王星) là hành tinh thứ tám và xa nhất tính từ Mặt Trời trong Hệ Mặt Trời. 
                    Nó là hành tinh lớn thứ tư về đường kính và lớn thứ ba về khối lượng. Sao Hải Vương có khối lượng riêng lớn nhất trong số các hành tinh khí trong hệ Mặt trời. 
                    Sao Hải Vương có khối lượng gấp 17 lần khối lượng của Trái Đất và hơi lớn hơn khối lượng của Sao Thiên Vương (xấp xỉ bằng 15 lần của Trái Đất). 
                    Sao Hải Vương quay trên quỹ đạo quanh Mặt Trời ở khoảng cách trung bình 30,1 AU, bằng khoảng 30 lần khoảng cách Trái Đất - Mặt Trời. 
                    Sao Hải Vương được đặt tên theo vị thần biển cả của người La Mã (Neptune). Nó có ký hiệu thiên văn là ♆, là biểu tượng cách điệu cây đinh ba của
                     thần Neptune hoặc chữ cái psi của Hy Lạp."
                }
                }
            );
        }
    }
}