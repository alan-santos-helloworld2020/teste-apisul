package com.onload.testejava.services;

import com.onload.testejava.interfaces.IElevadorService;
import com.onload.testejava.services.LeitorJson;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.HashMap;

import java.util.List;
import java.util.Map;

public class TesteService implements IElevadorService {

    LeitorJson leitor = new LeitorJson();
    List<Character> elevador = new ArrayList<Character>();
    List<Integer> andar = new ArrayList<Integer>();
    List<Character> turno = new ArrayList<Character>();

    @Override
    public List<Integer> andarMenosUtilizado() {
        // TODO Auto-generated method stub
        leitor.findAll().forEach(valor -> {
            andar.add(valor.getAndar());
            
        });
        int unique = 0;
        for (int i = 0; i < andar.size(); i++) {
            
            for (int j = 0; j < andar.size(); j++) {
                if(andar.get(i) != andar.get(j))
                {
                   unique = j; 
                                       
                } 
            }
            
        }
        System.out.println(unique);

        return null;
    }

    @Override
    public List<Character> elevadorMaisFrequentado() {
        // TODO Auto-generated method stub
        return null;
    }

    @Override
    public List<Character> periodoMaiorFluxoElevadorMaisFrequentado() {
        // TODO Auto-generated method stub
        return null;
    }

    @Override
    public List<Character> elevadorMenosFrequentado() {
        // TODO Auto-generated method stub
        return null;
    }

    @Override
    public List<Character> periodoMenorFluxoElevadorMenosFrequentado() {
        // TODO Auto-generated method stub
        return null;
    }

    @Override
    public List<Character> periodoMaiorUtilizacaoConjuntoElevadores() {
        // TODO Auto-generated method stub
        return null;
    }

    @Override
    public float percentualDeUsoElevadorA() {
        // TODO Auto-generated method stub
        return 0;
    }

    @Override
    public float percentualDeUsoElevadorB() {
        // TODO Auto-generated method stub
        return 0;
    }

    @Override
    public float percentualDeUsoElevadorC() {
        // TODO Auto-generated method stub
        return 0;
    }

    @Override
    public float percentualDeUsoElevadorD() {
        // TODO Auto-generated method stub
        return 0;
    }

    @Override
    public float percentualDeUsoElevadorE() {
        // TODO Auto-generated method stub
        return 0;
    }

}
