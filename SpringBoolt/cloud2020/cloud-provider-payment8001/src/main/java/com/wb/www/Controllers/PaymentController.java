package com.wb.www.Controllers;

import com.wb.www.entities.Payment;
import com.wb.www.services.IPaymentService;
import lombok.extern.slf4j.Slf4j;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RestController;

import javax.annotation.Resource;

@RestController
@Slf4j
public class PaymentController {
    @Resource
    private IPaymentService _service;

    @PostMapping(value="/payment/create")
    public Payment add(Payment payment)
    {
        _service.add(payment);
        return  payment;
    }
    @GetMapping(value="payment/{id}")
    public Payment find(int id)
    {
      return   _service.find(id);
    }


}
