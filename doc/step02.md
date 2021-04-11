# Step02. 책임, 역할
# Commander
## member
### 1. String 이름
- 지금은 'Zerg'로 생성
### 2. List<Unit> 내 유닛 리스트
- 새 유닛이 생성/삭제될 때 상호작용할 별도의 공간
- 책임 : 내가 가진 유닛들의 정보를 알려준다
- member : int 총 유닛 수, int 라바 수, int 드론 수, List<Unit> 라바 목록, List<Unit> 드론 목록
### 2. enum 저그 유닛 리스트
- 원래라면 저그,테란,프로토스 유닛 리스트가 있어야 하지만 지금은 저그만
- 책임 : 해당 리스트에 있는 유닛만 생성 가능하도록 유효성을 체크하기 위한 베이스
- 드론, 라바,  오버로드, 저글링, 히드라...
## Method
### 1. 유닛 생성(List<Unit> 저그 유닛 리스트, String 유닛명)
- 책임 : 유닛을 생성한다.
- member : List<Unit> 저그 유닛 리스트, String 유닛명
- 내 유닛 리스트에 있는 유닛 배열에 새 유닛을 추가한다.
### 2. 유닛 이동시킬 좌표 선택

- 책임 : 입력받은 마우스 좌표를 반환
- member : Vector3 마우스 입력받은 좌표, 유닛 이동시킬 좌표
- getMouseButtonDown 했을 때
마우스 입력받은 좌표 = Camera.main.ScreenToWorldPosigion(Input.musePosition);
- 유닛 이동시킬 좌표 = new Vector3(마우스 포지션 가져오기.x, 마우스 포지션 가져오기.y, 0);

### 3. 유닛 이동 명령

- 책임 : 유닛객체에 좌표를 전달하여 이동 명령
- 유닛.이동(유닛 이동시킬 좌표); // 유닛 선택해야 되는건 여기서 생략

# Unit

## Member

Float 속도: 0.5f(예)

Vector3 현재 좌표: 0 0 0(예)

## Method

### 1. 현재 좌표 갱신(변경된 좌표)

책임 : 현재 좌표 갱신

- 현재 좌표 = 변경된 좌표

### 2. 이동(Vector3 Commander가 명령한 좌표)

책임 : 입력받은 좌표로 이동

- transform.position = Vector3.MoveTowards(trnasform.position += Commander가 명령한 좌표 * 속도 * Time.deltaTime)
- 현재 좌표 갱신(Commander가 명령한 좌표)
  
# UML 다이어그램
![클래스 다이어그램 스케치3](/doc/resource/class_diagram03.png)
### 클래스 다이어그램 스케치 과정
- [클래스 다이어그램 스케치1](/class_diagram01.md)
- [클래스 다이어그램 스케치2](/class_diagram02.md)
- [클래스 다이어그램 스케치3](/class_diagram03.md)