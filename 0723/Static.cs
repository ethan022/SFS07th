﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// =======================================
//
// ✅ 정적 멤버란?
//  - 객체를 생성하지 않고도 클래스 이름으로 직접 사용할 수 있는 멤버입니다.
//  - static 키워드를 사용하여 정의합니다.
//
// ✅ 일반 멤버 vs 정적 멤버 비교
//
// ┌──────────────┬──────────────────────────┐
// │ 구분         │ 일반 멤버                    │ 정적 멤버 (static)               │
// ├──────────────┼──────────────────────────┤
// │ 객체 생성     │ 필요함                      │ ❌ 불필요 (클래스 이름으로 접근)
// │ 접근 방법     │ 객체이름.멤버               │ 클래스이름.정적멤버              │
// │ 메모리        │ 객체마다 개별 생성            프로그램 전체에서 하나만 생성     │
// └──────────────┴──────────────────────────┘
//
// ✅ 사용 예:
//   - 일반 멤버: 사람마다 이름, 나이 등 다른 값을 가질 때
//   - 정적 멤버: 공통 상수(PI), 전체 공용 메서드 등
//
// =======================================

namespace _0723
{
    // =======================================
    // 👤 Person 클래스: 일반 멤버 사용 예시
    // =======================================
    // 각 인스턴스(Person 객체)마다 name, age를 따로 저장하고
    // PrintInfo() 메서드도 객체를 통해 호출해야 합니다.
    internal class Person
    {
        // 인스턴스 변수 (일반 멤버)
        public string name;
        public int age;

        // 인스턴스 메서드 (객체를 통해 호출)
        public void PrintInfo()
        {
            Console.WriteLine($"{name}, {age}");
        }
    }

    // =======================================
    // 🧮 Math 클래스: 정적(static) 멤버 사용 예시
    // =======================================
    // 객체를 생성하지 않고도 클래스 이름으로 직접 접근 가능
    public class Math
    {
        // 정적 필드: 프로그램 전체에서 하나만 존재
        public static double PI = 3.1415;

        // 정적 메서드: 객체 생성 없이 클래스 이름으로 호출
        public static double GetCircleArea(double radius)
        {
            return PI * radius * radius;
        }
    }
}


