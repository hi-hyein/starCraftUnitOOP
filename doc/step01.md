# Step01.도메인 구조

- star craft → main stage
- commander → main stage의 주인공, 유닛에게 명령을 내림
- unit → commander의 명령을 받아 일을 하는 병사

# 협력

## Commander → Unit

1. 커맨더는 자신이 생성할 수 있는 유닛을 원하는 수 만큼 생성할 수 있다.
2. 커맨더는 내 유닛 중 원하는 수를 선택할 수 있다.
3. 커맨더는 선택한 내 유닛들에게 원하는 좌표로 이동하도록 이동명령을 내릴 수 있다.

## Unit ← Commander

1. 유닛은 커맨더의 이동명령에 따라 커맨더가 원하는 좌표로 이동할 수 있다.

# 구현
- star craft 라는 main stage에서 명령을 내리는 commander 객체
- commander가 명령을 내릴 unit 객체
- commander와 unit의 종류 구현은 저그(commander)와 두마리의 라바,드론으로(unit) 축소

# Commander

- 저그
- 프로토스
- 테란

## 1. 공통 행동

1. 유닛 생성
2. 유닛 이동
3. 유닛 선택

### 1-1. 유닛 생성

- 유닛 객체 사용

### 1-2. 유닛 선택

### 1-3. 유닛 이동

## 2. 프로퍼티

1. 내 유닛?

### 1-1. 내 유닛

## 필드

1. 커맨더 이름

### 1-1. 커맨더 이름

- 저그, 테란, 프로토스

# Unit

- 저그유닛
- 프로토스유닛
- 테란유닛

## 1. 공통 행동

1. 이동

### 1-1. 이동

## 2. 프로퍼티

## 3. 필드

1. 유닛 이름
2. 현재 좌표

# 개념 구조 다이어그램
[다이어그램 링크(작업 중)](https://drive.google.com/file/d/1SJmT87BOpjt212SsEdUoYup1SqPzIjWb/view?usp=sharing)
