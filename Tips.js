const Amountcal=()=>{
    let amount=parseInt(document.getElementById("Amount").value);
    let tips=parseInt(document.getElementById("TipsAmount").value);
    
     let tip=(amount*tips)/100;
    let totalamount=(amount+tip);
    document.getElementById("cal").innerHTML="the total amount is"+totalamount;
};