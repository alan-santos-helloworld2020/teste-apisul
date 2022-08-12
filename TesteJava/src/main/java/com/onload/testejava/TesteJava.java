/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Project/Maven2/JavaApp/src/main/java/${packagePath}/${mainClassName}.java to edit this template
 */

package com.onload.testejava;

import com.onload.testejava.services.LeitorJson;
import com.onload.testejava.services.TesteService;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author alan
 */
public class TesteJava {

    public static void main(String[] args) {
        TesteService servico = new TesteService();
        servico.andarMenosUtilizado();   
 
    }
}
