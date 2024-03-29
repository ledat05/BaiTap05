﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap05
{
    class QuanLyCD
    {
        private CD[] ds;
        private int n;

        //Phucthuc constructor
        public QuanLyCD()
        {
            ds = new CD[100];
        }
        public QuanLyCD(int sophantu)
        {
            ds = new CD[sophantu];
            n = 0;
        }
        public void themCD(CD cD)
        {
            if (n >= ds.Length)
            {
                Console.WriteLine("Danh Sach Da Day");
            } 
              else
            {
                if (!KiemTraTrungCD(cD.Macd))
                    ds[n++] = cD;
                else
                {
                    Console.WriteLine("Trung MaCD");
                }    
            }    

        }
        private bool KiemTraTrungCD(int Macd)
        {
            for (int i=0;i<n;i++)
            {
                if(ds[i].Macd==Macd)
                {
                    return true;
                }    
            }
            return false;
        }
        public double tinhGiaTB()
        {
            int tonggia = 0;
            for (int i = 0; i < 0; i++)
            {
                tonggia += ds[i].Dongia;
            }
            return (double)tonggia / n;
                
        }
        public void Xuat()
        {
            Console.WriteLine("{0,10} {1,30} {2,30} {3,10} {4,15}"
                , "MaCD", "TuaCD", "Ca si", "So Bai Hat", "Gia Hanh");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(ds[i].ToString());
            }    
        }
        public void SapXepGiamTheoGiaThanh()
        {
            CD tam;
            for(int i=0;i<n-1;i++)
            {
                for (int j=i+1; j<n;j++)
                {
                    if (ds[i].Dongia < ds[j].Dongia)
                    {
                        tam = ds[i];
                        ds[i] = ds[j];
                        ds[j] = tam;
                    }    
                }    
            }    
        }
    }

}
