# Step01.도메인 구조

- star craft → main stage
- commander → main stage의 주인공, 유닛에게 명령을 내림
- unit → commander의 명령을 받아 일을 하는 병사

# 협력

## Commander → Unit
1. 커맨더는 내 유닛 중 원하는 수를 선택할 수 있다.
2. 커맨더는 선택한 내 유닛들에게 원하는 좌표로 이동하도록 이동명령을 내릴 수 있다.

## Commander -> Building
1. 커맨더는 조건이 맞다면 구조체를 생성할 수 있다.
2. 커맨더는 구조체를 통해 조건이 맞다면 유닛을 생성할 수 있다.
## Unit ← Commander

1. 유닛은 커맨더의 이동명령에 따라 커맨더가 원하는 좌표로 이동할 수 있다.

## Building -> Unit
- 구조체는 유닛을 생성할 수 있다.

# 구현
- star craft 라는 main stage에서 명령을 내리는 commander 객체
- commander가 명령을 내릴 unit 객체
- commander와 unit의 종류 구현은 저그(commander)와 두마리의 라바,드론으로(unit) 축소
- Building은 Hatchery 레벨 구현

# Commander
- 저그
- 프로토스
- 테란
## 1. 공통 행동
1. 유닛 이동
2. 유닛 선택
3. 유닛 이동시킬 좌표 선택
## 2. 프로퍼티
1. 미네랄
2. 가스
3. 현재 인구수
4. 최대 인구수
5. 내 유닛 리스트
# Unit
- 저그유닛 (라바,드론)
## 1. 공통 행동
1. 이동
## 2. 프로퍼티
1. 현재 좌표
2. 이동 속도

# Building
- 구조체
## Hatchery
- 라바생성
- 드론생성
