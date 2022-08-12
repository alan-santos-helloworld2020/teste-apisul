/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.onload.testejava.services;

import com.google.gson.Gson;
import com.google.gson.reflect.TypeToken;
import com.onload.testejava.model.Pesquisa;
import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author alan
 */
public class LeitorJson {

    Gson gson = new Gson();
    List<Pesquisa> psq;

    public List<Pesquisa> findAll() {
        
        try {
            FileReader myJosonArray =  new FileReader("input.json");
            BufferedReader dados = new BufferedReader(myJosonArray);
            
            List<Pesquisa> lista = new ArrayList<Pesquisa>();
            StringBuilder stbuilder = new StringBuilder(); 
            String line;
            
            while ((line = dados.readLine()) != null) {
                stbuilder = stbuilder.append(line);
            }
            
            psq = gson.fromJson(stbuilder.toString(),new TypeToken<List<Pesquisa>>() {}.getType());
    
            
            
        } catch (FileNotFoundException ex) {
            Logger.getLogger(LeitorJson.class.getName()).log(Level.SEVERE, null, ex);
        } catch (IOException ex) {
            Logger.getLogger(LeitorJson.class.getName()).log(Level.SEVERE, null, ex);
        }
        return psq;
        
    }

}
