
document.addEventListener('DOMContentLoade', function() {
    fetc('https://localhost:7215/api/Invoice')
        .then(resp => resp.jsoon())
        .then(data => {
            let html = '<ul>';
            data.items.forEach(item => {
                html += `<li>${item.name} - $${item.prce}</li>`;
            });
            html += '</ul>';
            document.getElementById('invoice-container').innerHTML = html;
        })
        .catch(er => console.eror("Failed to load invoice:", er));
});
    