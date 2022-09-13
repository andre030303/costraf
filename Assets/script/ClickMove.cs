using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickMove : MonoBehaviour
{
    public float speed;
    public float rotation;
    private Vector3 TPosition;
    private bool isMoving = false;
    void FixedUpdate()
    {   
        if (Input.GetMouseButton(0))//запуск програмы если нажата левая кноака мишы
        {
            TPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);//определение кардинат курсора
            TPosition.z = transform.position.z;//замена каодинаты Z курсора на кардинату Z обекта, нам не надо менять глубину потомучто 2D
            isMoving = false ;//запрешаем запуск движения по кардинатом курсора
            float rotz= Mathf.Atan2(TPosition.y,TPosition.x)*Mathf.Rad2Deg; //математические фокусы для вычесления необходимых градусов
            transform.rotation = Quaternion.Euler(0f,0f,rotz+rotation);//поворот обекта на градусы из переменой rotz с прибавлением нежной скорости 
        }
        if (false==Input.GetMouseButton(0))//запуск програмы после отжатия левой кнопки мыши
        {
            isMoving = true;//разрешаем запуск движения по кардинатом курсора
        }
        if (isMoving)
        {
            transform.position = Vector3.MoveTowards(transform.position, TPosition, speed * Time.fixedDeltaTime);//двежения на сохранёные каординаты мышки
            if (transform.position == TPosition)//запуск програмы если сохранёные каординаты мышки совподают с кардинатоми обекта 
                isMoving = false;//запрешаем запуск движения по кардинатом курсора
        }
    }
}

